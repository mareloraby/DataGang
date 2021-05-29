#!/usr/bin/env
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
model2 = keras.models.load_model(fileDirectory+'/models/my_model.h5')
def make_prediction(path):
    image=cv2.imread(path)
    image =preprocessing([image])
    pred=model2.predict(image)
    classes={0: 'Apple scab',
 1: 'Black_rot',
 2: 'Cedar_apple_rust',
 3: 'healthy_apple',
 4: 'Black_rot',
 5: 'Esca(Black_Measles)',
 6: 'Leafblight(Isariopsis_Leaf_Spot)',
 7: 'healthy_grape'}
    return(classes[pred.argmax()])
def main():
    os.getcwd()
    pat=sys.argv

    try:
        print(make_prediction(pat[1]))
    except:
        print("file name cannot contain spaces")

if __name__=='__main__':
    main()