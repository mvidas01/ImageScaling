using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageScalling
{
    public class SuperResolution
    {
        string script;

        //начальный путь до скрипта
        public SuperResolution(string script = @"superresolution.py")
        {
            this.script = script;

        }
        //путь до интерпритатора python
        private string GetPythonPath()
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + "where python");

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = procStartInfo;
                process.Start();


                process.WaitForExit();


                string result = process.StandardOutput.ReadToEnd();
                return result;
            }
        }

        //SuperResolution Start
        public void Start(string method, string imageFrom, string imageTo)
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo();

            procStartInfo.FileName = GetPythonPath();
            procStartInfo.Arguments = $"\"{script}\" \"{method}\" \"{imageFrom}\" \"{imageTo}\"";
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            string result = null;
            string errors = null;

            //запуск интерпритатора вместе со скриптом
            using (Process process = Process.Start(procStartInfo))
            {
                errors = process.StandardError.ReadToEnd();
                result = process.StandardOutput.ReadToEnd();
            }


        }
        public async Task StartAsync(string method, string imageFrom, string imageTo)
        {
            await Task.Run(() => Start(method, imageFrom, imageTo));
        }
    }
}
