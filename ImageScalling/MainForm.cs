using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScalling
{
    public partial class MainForm : Form
    {
        string tempDirectory = @"Temp/";

        public MainForm()
        {
            InitializeComponent();
            ClearСache();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            methodBox.SelectedIndex = 1;
            superResolutionSettings.BringToFront();
            superResolutionSettings.Visible = true;

            #region Interpolation Setting

            typeInterpolation.SelectedIndex = 1;
            proportionsInterpolation.Checked = true;
            widthInterpolation.Enabled = false;
            heightInterpolation.Enabled = false;

            #endregion

            #region SuperResolution Setting

            superResolutionMethod.SelectedIndex = 3;

            #endregion

        }

        #region Style

        private void Button_MouseLeave1(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.FlatAppearance.BorderSize = 0;

        }
        private void Button_MouseMove1(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.FlatAppearance.BorderSize = 2;
        }

        private void loadInputButton_MouseMove(object sender, MouseEventArgs e)
        {
            inputUp.Visible = true;
            inputDown.Visible = true;
        }
        private void loadInputButton_MouseLeave(object sender, EventArgs e)
        {
            inputUp.Visible = false;
            inputDown.Visible = false;
        }

        #endregion

        #region Interface
        //загрузка исходного изображения
        private void loadInputButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string inputImagePath = ofd.FileName;
                    try
                    {
                        inputImageBox.Image = Image.FromFile(inputImagePath);
                        inputImageBox.ImageLocation = inputImagePath;
                        loadInputButton.Visible = false;
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось загрузить изображение. Попробуйте загрузить другой файл.", "Не удалось загрузить изображение.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadInputButton.Visible = true;
                    }


                }
            }
        }

        //очистка pictureBox
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (outputImageBox.Image != null)
            {
                var result = MessageBox.Show("Хотите сохранить результаты?", "Сохранение результатов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveImage();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            inputImageBox.ImageLocation = null;
            inputImageBox.Image = null;
            outputImageBox.Image = null;
            outputImageBox.Image = null;
            loadInputButton.Visible = true;
        }

        //показать исходное изображение
        private void inputShowButton_Click(object sender, EventArgs e)
        {

            if (inputImageBox.Image != null)
            {
                PictureForm pictureForm = new PictureForm(inputImageBox.Image, "Изначальное изображение");
                pictureForm.Show();
            }


        }

        //показать выходное изображение
        private void outputShowButton_Click(object sender, EventArgs e)
        {
            if (outputImageBox.Image != null)
            {
                PictureForm pictureForm = new PictureForm(outputImageBox.Image, "Результат");
                pictureForm.Show();
            }
        }

        //смена операции
        private void methodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = methodBox.SelectedIndex;

            if (index == 0)
            {
                interpolationSettings.BringToFront();
                interpolationSettings.Visible = true;
            }
            else if (index == 1)
            {
                superResolutionSettings.BringToFront();
                superResolutionSettings.Visible = true;
            }
        }

        //ГЛАВНАЯ ФУНКЦИЯ
        private async void startButtonAsync_Click(object sender, EventArgs e)
        {
            outputImageBox.Image = null;
            outputImageBox.ImageLocation = null;
            string inputImage = inputImageBox.ImageLocation;

            if (String.IsNullOrEmpty(inputImage))
            {
                //если начальное изображение не выбрано
                MessageBox.Show("Для начала работы выберите изображение!", "Выберите изображение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            //интерполяция 
            if (methodBox.SelectedIndex == 0)
            {
                Interpolation();
            }
            #region Super Resolution
            //вызов superresolution
            else if (methodBox.SelectedIndex == 1)
            {
                //блокировка интерфейса, показ LoadingBar
                BlockInterface();
                ShowLoading();

                await SuperResolution(inputImage);

                //разблокировка интерфейса
                UnblockInterface();
                HideLoading();

            }
            #endregion
        }

        //сохранить все результаты
        private void saveAllButton_Click(object sender, EventArgs e)
        {
            SaveImage();
        }
        private void saveInput_Click(object sender, EventArgs e)
        {
            SaveImage(1);
        }
        private void saveOutput_Click(object sender, EventArgs e)
        {
            SaveImage(2);
        }

        #region Interpolation Setting
        private void proportionsInterpolation_CheckedChanged(object sender, EventArgs e)
        {
            if (proportionsInterpolation.Checked)
            {
                upscalingSizeInterpolation.Enabled = true;
                widthInterpolation.Enabled = false;
                heightInterpolation.Enabled = false;
            }
            else
            {
                upscalingSizeInterpolation.Enabled = false;
                widthInterpolation.Enabled = true;
                heightInterpolation.Enabled = true;
            }
        }

        //текст бокс для целочисленных чисел и с плавающей точкой
        private void DoubleInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = sender as TextBox;

            if (!char.IsControl(e.KeyChar))
            {
                //разделитель еще не стоит
                if (((e.KeyChar == '.') || (e.KeyChar == ',')) && (textbox.Text.IndexOf(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]) == -1))
                {
                    e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                }
                else if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        //текстбокс для целочиселенных
        private void Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #endregion

        #region Logic
        private async Task SuperResolution(string inputImage)
        {
            //метод superresolution
            string method = superResolutionMethod.SelectedItem.ToString();
            //сохряняем выходное изображение в папку Temp
            string outputImageName = Path.GetFileNameWithoutExtension(Path.GetFileName(inputImage));
            string outputImagePath = tempDirectory + outputImageName + "_" + method + ".png";

            //удаляем выходное изображение, если оно уже существует
            if (File.Exists(outputImagePath))
            {
                File.Delete(outputImagePath);
            }

            //создание супер-разрешения, и вызов асинхронного метода
            SuperResolution superResolution = new SuperResolution();
            await superResolution.StartAsync(method, inputImage, outputImagePath);

            //если выходное изображение получено, операция успешна
            if (File.Exists(outputImagePath))
            {
                outputImageBox.Image = Image.FromFile(outputImagePath);
                outputImageBox.ImageLocation = outputImagePath;
            }
            else
            {
                MessageBox.Show("Произошла ошибка, не удалось завершить преобразование!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Interpolation()
        {
            InterpolationMode interpolationMode;

            if (typeInterpolation.SelectedIndex == 1)
                interpolationMode = InterpolationMode.HighQualityBicubic;
            else if (typeInterpolation.SelectedIndex == 2)
                interpolationMode = InterpolationMode.HighQualityBilinear;
            else
                interpolationMode = InterpolationMode.Default;

            try
            {
                if (proportionsInterpolation.Checked)
                {
                    int scale = Convert.ToInt32(upscalingSizeInterpolation.Text);

                    Bitmap output = ImageInterpolation.ResizeImage(inputImageBox.Image, interpolationMode, scale);

                    outputImageBox.Image = output;
                }
                else
                {
                    int width = Convert.ToInt32(widthInterpolation.Text);
                    int height = Convert.ToInt32(heightInterpolation.Text);

                    Bitmap output = ImageInterpolation.ResizeImage(inputImageBox.Image, interpolationMode, width, height);

                    outputImageBox.Image = output;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка! Неверно заданы параметры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Helpers
        private void SaveImage(int choise = 0)
        {
            //сохранение изображений
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Сохранение результатов";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folder.SelectedPath;

                Image inputImage = inputImageBox.Image;
                Image outputImage = outputImageBox.Image;

                string date = DateTime.Now.ToString("yyyy-MM-dd-hhmmss");

                //сохранить оба
                if (choise == 0)
                {
                    if(inputImage != null)
                        inputImage.Save(folderPath + "\\inputImage(" + date + ").bmp", ImageFormat.Bmp);
                    if(outputImage != null)
                        outputImage.Save(folderPath + "\\outputImage(" + date + ").bmp", ImageFormat.Bmp);
                }
                //сохранить только входное изображение
                else if (choise == 1)
                {
                    if(inputImage != null)
                        inputImage.Save(folderPath + "\\inputImage(" + date + ").bmp", ImageFormat.Bmp);
                }
                //сохранить только выходное изображение
                else if (choise == 2)
                {
                    if(outputImage != null)
                        outputImage.Save(folderPath + "\\outputImage(" + date + ").Bmp", ImageFormat.Bmp);
                }
            }
        }
        private void BlockInterface()
        {
            methodBox.Enabled = false;
            interpolationSettings.Enabled = false;
            superResolutionSettings.Enabled = false;
            startButton.Enabled = false;
            clearButton.Enabled = false;
            loadInputButton.Enabled = false;
            saveAllButton.Enabled = false;
            saveInput.Enabled = false;
            saveOutput.Enabled = false;
        }
        private void UnblockInterface()
        {
            methodBox.Enabled = true;
            interpolationSettings.Enabled = true;
            superResolutionSettings.Enabled = true;
            startButton.Enabled = true;
            clearButton.Enabled = true;
            loadInputButton.Enabled = true;
            saveAllButton.Enabled = true;
            saveInput.Enabled = true;
            saveOutput.Enabled = true;
        }
        private void ShowLoading()
        {
            loadingLabel.Visible = true;
            loadingLabel.BringToFront();
            loadingBox.Visible = true;
            loadingBox.BringToFront();
        }
        private void HideLoading()
        {
            loadingLabel.Visible = false;
            loadingLabel.SendToBack();
            loadingBox.Visible = false;
            loadingBox.SendToBack();
        }
        private void ClearСache()
        {
            if (Directory.Exists(tempDirectory))
            {
                Directory.Delete(tempDirectory, true);
            }
            Directory.CreateDirectory(tempDirectory);
        }

        #endregion
    }
}
