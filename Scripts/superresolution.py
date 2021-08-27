#! /usr/bin/env python
# -*- coding: utf-8 -*-
import sys 
import numpy as np

import colorama
from colorama import Fore, Back, Style
from PIL import Image
from ISR.models import RDN
from ISR.models import RRDN

colorama.init()
##параметры командной строки
try:
   method = sys.argv[1]
   fileFrom = sys.argv[2]
   fileTo = sys.argv[3]
except Exception as e:
    print(Fore.RED, "Error! Wrong parameters!")
    print(Style.RESET_ALL)
    quit()

##подготовка изображения
try:
   img = Image.open(fileFrom)
   lr_img = np.array(img)
except:
    print(Fore.RED, "Error! File doesn't exists!")
    print(Style.RESET_ALL)
    quit()

##RDN: psnr-large, psnr-small, noise-cancel
##RRDN: gans

model = None

if(method == 'psnr-large'):
   model = RDN(weights='psnr-large')

elif(method == 'psnr-small'):
    model = RDN(weights='psnr-small')

elif(method == 'noise-cancel'):
    model = RDN(weights='noise-cancel')

elif(method == 'gans'):
    model = RRDN(weights='gans')


if(model is None):
    print(Fore.RED, "Error! Model don't exists!")
    print(Style.RESET_ALL)
    quit()

else:
    print(Fore.GREEN, "Please wait for loading, this may take some time.")
    print(Fore.YELLOW)
    try:
        sr_img = model.predict(lr_img)
        result = Image.fromarray(sr_img)
        result.save(fileTo)
    except:
        info= sys.exc_info()  
        print(Fore.RED, info[0], ":" , info[1])
        print(Style.RESET_ALL)
        quit()





