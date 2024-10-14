[![Twitter: @NorowaretaGemu](https://img.shields.io/badge/X-@NorowaretaGemu-blue.svg?style=flat)](https://x.com/NorowaretaGemu)

<br>
<div align="center">
  <a href="https://ko-fi.com/cursedentertainment">
    <img src="https://ko-fi.com/img/githubbutton_sm.svg" alt="ko-fi" style="width: 20%;"/>
  </a>
</div>
<br>

<div align="center">
  <img alt="Unity" src="https://img.shields.io/badge/unity%20-%231F5B94.svg?&style=for-the-badge&logo=unity&logoColor=white"/>
</div>
<div align="center">
  <img alt="Python" src="https://img.shields.io/badge/python%20-%231F5B94.svg?&style=for-the-badge&logo=python&logoColor=white"/>
    <img alt="HTML5" src="https://img.shields.io/badge/html5%20-%231F5B94.svg?&style=for-the-badge&logo=html5&logoColor=white"/>
  <img alt="CSS3" src="https://img.shields.io/badge/css3%20-%231F5B94.svg?&style=for-the-badge&logo=css3&logoColor=white"/> 
</div>
<div align="center">
    <img alt="TensorFlow" src="https://img.shields.io/badge/tensorflow%20-%231F5B94.svg?&style=for-the-badge&logo=tensorflow&logoColor=white"/>
    <img alt="Flask" src="https://img.shields.io/badge/flask%20-%231F5B94.svg?&style=for-the-badge&logo=flask&logoColor=white"/>
</div>
<div align="center">
  <img alt="PowerShell" src="https://img.shields.io/badge/PowerShell-%23323330.svg?&style=for-the-badge&logo=powershell&logoColor=white"/>
  <img alt="Shell" src="https://img.shields.io/badge/Shell-%23323330.svg?&style=for-the-badge&logo=gnu-bash&logoColor=white"/>
  <img alt="Batch" src="https://img.shields.io/badge/Batch-%23323330.svg?&style=for-the-badge&logo=windows&logoColor=white"/>
  </div>
<br>
<br>

# Synthia-Unity

<div align="center">
<a href="https://github.com/SynthWomb" target="_blank">
    <img src="https://github.com/SynthWomb/Synthia/raw/main/demo_images/synthia00-cover.png"
        alt="SynthiaGPT">
</a>
</div>
<br>
<br>
<div align="center">
<a href="https://synthwomb-synthia.onrender.com/" target="_blank" align="center">
    <img src="https://github.com/SynthWomb/Synthia/blob/main/demo_images/synthia_qr.jpg"
        alt="SynthWomb" style="width:200px;"/>
</a>
</div>
<br>

SynthiaGPT leverages Google's Gemini & the Hugging Face Transformers library to interact with a pre-trained GPT-2 model. It employs TensorFlow for model management and AutoTokenizer for efficient tokenization. The script enables users to input prompts interactively, generating text responses from the GPT-2 model. To improve the user experience, unnecessary warning messages related to the transformers library are effectively suppressed.

## Scripts:

- **main.py:** The selection menu for SynthiaGPT
- **app.py:** Run SynthiaGPT as a web-server
- **redirect.py:** Redirect to main.py

### /scripts/

- **gemini.py:** Run SynthiaGPT with Gemini
- **gemini_t2s.py:** Run SynthiaGPT with Gemini and text-to-speech functionality
- **transformer.py:** Run SynthiaGPT
- **transformer_t2s.py:** Run SynthiaGPT with text-to-speech functionality
- **transformer_s2t2s.py:** Run SynthiaGPT with speech-to-text-to-speech functionality
- **transformer_webcam.py:** Run SynthiaGPT with webcam functionality
- **install_dependencies.py:** Install dependencies

### /scripts/system

- **generate_text.py:** The GPT text generator
- **greeting.py:** Greets the user
- **clean_text.py:** Clean text from recorded voice audio
- **stt.py:** Speech-to-text
- **tts.py:** Text-to-speech
- **capture_photo.py:** Capture photo with a webcam
- **play_audio.py:** Play generated audio
<br>
<div align="center">
<a href="https://synthwomb-synthia.onrender.com/" target="_blank">
    <img src="https://github.com/SynthWomb/Synthia/raw/main/demo_images/screenshot.png"
        alt="SynthiaGPT">
</a>
</div>
<br>

## Requirements:

```bash
transformers==4.37.1
tensorflow==2.14.0
torch==2.1.1
torchvision==0.16.1
torchaudio==2.1.1
flask==3.0.0
gtts==2.5.0
pyaudio==0.2.14 
pydub==0.25.1
beautifulsoup4==4.10.0
SpeechRecognition==3.10.1
pygame==2.5.2
google-generativeai==0.3.2
```
## How to Run:
```bash
pip install -r requirements.txt
```
```bash
pip install torch torchvision torchaudio
```
```bash
python main.py
```
```bash
python app.py
```
<br>

- [GloriosaAI Repository](https://github.com/CursedPrograms/GloriosaAI)
- [Gender-Age-ID Repository](https://github.com/CursedPrograms/Gender-Age-ID)
- [Detect-Face Repository](https://github.com/CursedPrograms/Detect-Face)
- [Image-Generator Repository](https://github.com/CursedPrograms/Image-Generator)

<br>

<div align="center">
<a href="https://github.com/SynthWomb" target="_blank" align="center">
    <img src="https://github.com/SynthWomb/synth.womb/blob/main/logos/synthwomb07.png"
        alt="SynthWomb" style="width:200px;"/>
</a>
</div>
<br>
<div align="center">
<a href="https://cursed-entertainment.itch.io/" target="_blank">
    <img src="https://github.com/CursedPrograms/cursedentertainment/raw/main/images/logos/logo-wide-grey.png"
        alt="CursedEntertainment Logo" style="width:250px;">
</a>
</div>
