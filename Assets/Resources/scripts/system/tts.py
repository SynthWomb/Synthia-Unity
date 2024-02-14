import os
from gtts import gTTS
from .clean_text import clean_text
from .play_audio import play_audio

def text_to_speech(text):
    cleaned_text = clean_text(text)
    tts = gTTS(text=cleaned_text, lang='en', slow=False)
    
    audio_path = "output/audio/output.mp3"
    
    # Check if the directory exists
    os.makedirs(os.path.dirname(audio_path), exist_ok=True)
    
    # Check if the file exists
    assert os.path.isfile(audio_path), f"File '{audio_path}' does not exist"
    
    # Open the file for reading (optional)
    with open(audio_path, "r") as f:
        pass

    # Save the TTS output to the file
    tts.save(audio_path)
    
    # Play the audio
    play_audio(audio_path)
