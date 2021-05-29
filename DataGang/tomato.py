#!/usr/bin/env</font>
import os
import sys
import tensorflow as tf
import numpy as np
from tensorflow import keras
import cv2
import matplotlib.pyplot as plt
import pathlib 

def preprocessing(input_tensor):
    output_tensor = tf.cast(input_tensor, dtype=tf.float32)
    output_tensor = tf.image.resize_with_pad(output_tensor, target_height=224, target_width=224)
    # output_tensor = keras.keras_applications.mobilenet.preprocess_input(output_tensor, data_format="channels_last")
    return output_tensor

absolutepath = os.path.abspath(__file__)
fileDirectory = os.path.dirname(absolutepath).replace('\\', '/')
model2 = keras.models.load_model(fileDirectory+'/models/tomato_model.h5')
def make_prediction(path):
    image=cv2.imread(path)
    image =preprocessing([image])
    pred=model2.predict(image)
    classes={0: 'Bacterial_spot',
 1: 'Black_mold',
 2: 'Gray_spot',
 3: 'Tomato_Late_blight',
 4: 'Healthy_Tomato',
 5: 'Powdery_mildew'}
    return(classes[pred.argmax()])
def main():
    os.getcwd()
    pat=sys.argv
    try:
        print(make_prediction(pat[1]))
    except:
        e = sys.exc_info()[0]
        
        print("file name cannot contain spaces")
        print(e)

if __name__=='__main__':
    main()