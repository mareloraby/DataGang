
# Bug Quest, a web-application, targeted for farmers and home gardeners.


## Image uploading guidlines
- Path must not contain spaces
- Same image name cannot be uploaded twice
- Using a mobile phone with an embedded camera, user will be prompted to choose whether to upload or capture an image.


## Running

To run the application, the following python packages are required
- os
- sys
- numpy
- tensorflow
- matplotlib
- pyplot
- keras
- spaCy
- en_core_web_sm
- wikipedia
- gensim==3.8.1
- argparse
- googlesearch 
- pathlib 
- cv2


Alternatively, in [Homepage.aspx.cs](https://github.com/mareloraby/DataGang/blob/master/DataGang/Homepage.aspx.cs), you can get stub returns values from methods by:
- commenting line [282](https://github.com/mareloraby/DataGang/blob/cedf5c5919b4f3f858fb86ac3e8a96565ed7e9e8/DataGang/Homepage.aspx.cs#L282) and uncommenting line [283](https://github.com/mareloraby/DataGang/blob/cedf5c5919b4f3f858fb86ac3e8a96565ed7e9e8/DataGang/Homepage.aspx.cs#L283) to get dummy info and links
- commenting line [250](https://github.com/mareloraby/DataGang/blob/cedf5c5919b4f3f858fb86ac3e8a96565ed7e9e8/DataGang/Homepage.aspx.cs#L250) and uncommenting line [251](https://github.com/mareloraby/DataGang/blob/cedf5c5919b4f3f858fb86ac3e8a96565ed7e9e8/DataGang/Homepage.aspx.cs#L251) to get a diagnosis from this set:
```
  ('Apple_scab',
  'Black_rot',
  'Gymnosporangium',
  'healthy_apple',
  'Black_rot',
  'Esca_Black_Measles',
  'Isariopsis_Leaf_Spot',
  'healthy_grape', 
  'Diamondback_moth',
  'Leafminer',
  'Mildew',
  'Bacterial_spot',
  'Black_mold',
  'Gray_spot',
  'Tomato_Late_blight',
  'Healthy_Tomato',
  'Powdery_mildew',
  'Healthy potato',
  'potato_late_blight')
  ```
 
## The development and testing python environment for further reference
  ```


absl-py                   0.12.0                   pypi_0    pypi
astunparse                1.6.3                    pypi_0    pypi
beautifulsoup4            4.9.3                    pypi_0    pypi
blis                      0.7.4                    pypi_0    pypi
ca-certificates           2020.10.14                    0    anaconda
cached-property           1.5.2                    pypi_0    pypi
cachetools                4.2.1                    pypi_0    pypi
catalogue                 2.0.4                    pypi_0    pypi
certifi                   2020.6.20                py37_0    anaconda
chardet                   4.0.0                    pypi_0    pypi
click                     7.1.2                    pypi_0    pypi
cryptography              3.4.7                    pypi_0    pypi
cudatoolkit               11.0.3               h3f58a73_8    conda-forge
cudnn                     8.0.5.39             hfe7f257_1    conda-forge
cycler                    0.10.0                   pypi_0    pypi
cymem                     2.0.5                    pypi_0    pypi
cython                    0.29.21                  pypi_0    pypi
en-core-web-sm            3.0.0                    pypi_0    pypi
flatbuffers               1.12                     pypi_0    pypi
gast                      0.3.3                    pypi_0    pypi
gensim                    3.8.1                    pypi_0    pypi
google                    3.0.0                    pypi_0    pypi
google-auth               1.29.0                   pypi_0    pypi
google-auth-oauthlib      0.4.4                    pypi_0    pypi
google-oauth              1.0.1                    pypi_0    pypi
grpcio                    1.32.0                   pypi_0    pypi
h5py                      2.10.0                   pypi_0    pypi
idna                      2.10                     pypi_0    pypi
joblib                    1.0.1              pyhd3eb1b0_0
keras                     2.4.3                    pypi_0    pypi
keras-preprocessing       1.1.2                    pypi_0    pypi
kiwisolver                1.3.1                    pypi_0    pypi
markdown                  3.3.4                    pypi_0    pypi
matplotlib                3.4.1                    pypi_0    pypi
mne                       0.23.0                   pypi_0    pypi
murmurhash                1.0.5                    pypi_0    pypi
numpy                     1.19.5                   pypi_0    pypi
oauthlib                  3.1.0                    pypi_0    pypi
opencv-python             4.5.2.52                 pypi_0    pypi
openssl                   1.1.1h               he774522_0    anaconda
opt-einsum                3.3.0                    pypi_0    pypi
pandas                    1.2.4                    pypi_0    pypi
pathy                     0.5.2                    pypi_0    pypi
pillow                    8.2.0                    pypi_0    pypi
pip                       21.1.1                   pypi_0    pypi
preshed                   3.0.5                    pypi_0    pypi
protobuf                  3.17.0                   pypi_0    pypi
pyasn1                    0.4.8                    pypi_0    pypi
pyasn1-modules            0.2.8                    pypi_0    pypi
pydantic                  1.7.4                    pypi_0    pypi
pyedflib                  0.1.20                   pypi_0    pypi
pyopenssl                 20.0.1                   pypi_0    pypi
python                    3.7.3                h8c8aaf0_1
python_abi                3.7                     1_cp37m    conda-forge
pytz                      2021.1                   pypi_0    pypi
pyyaml                    5.4.1                    pypi_0    pypi
requests                  2.25.1                   pypi_0    pypi
requests-oauthlib         1.3.0                    pypi_0    pypi
rsa                       4.7.2                    pypi_0    pypi
sampen                    0.0.17                   pypi_0    pypi
scikit-learn              0.24.1                   pypi_0    pypi
scipy                     1.6.3                    pypi_0    pypi
setuptools                52.0.0           py37haa95532_0
sklearn                   0.0                      pypi_0    pypi
smart-open                3.0.0                    pypi_0    pypi
soupsieve                 2.2.1                    pypi_0    pypi
spacy                     3.0.6                    pypi_0    pypi
spacy-legacy              3.0.5                    pypi_0    pypi
sqlite                    3.35.4               h2bbff1b_0
srsly                     2.4.1                    pypi_0    pypi
tensorboard               2.4.1                    pypi_0    pypi
tensorboard-plugin-wit    1.8.0                    pypi_0    pypi
tensorflow-estimator      2.4.0                    pypi_0    pypi
tensorflow-gpu            2.4.1                    pypi_0    pypi
termcolor                 1.1.0                    pypi_0    pypi
thinc                     8.0.3                    pypi_0    pypi
threadpoolctl             2.1.0                    pypi_0    pypi
tqdm                      4.61.0                   pypi_0    pypi
typer                     0.3.2                    pypi_0    pypi
typing-extensions         3.7.4.3                  pypi_0    pypi
urllib3                   1.26.4                   pypi_0    pypi
vc                        14.2                 h21ff451_1
vs2015_runtime            14.27.29016          h5e58377_2
wasabi                    0.8.2                    pypi_0    pypi
werkzeug                  2.0.1                    pypi_0    pypi
wheel                     0.36.2             pyhd3eb1b0_0
wikipedia                 1.4.0                    pypi_0    pypi
wincertstore              0.2                      py37_0
wrapt                     1.12.1                   pypi_0    pypi

  ```
