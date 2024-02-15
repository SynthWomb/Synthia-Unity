import os
from gtts import gTTS
from .clean_text import clean_text
from .play_audio import play_audio

def text_to_speech(text):
    cleaned_text = clean_text(text)
    
    # Check if there is any text to speak
    if cleaned_text.strip():
        tts = gTTS(text=cleaned_text, lang='en', slow=False)
        
        audio_path = "output/audio/output.mp3"
        
        # Check if the directory exists
        os.makedirs(os.path.dirname(audio_path), exist_ok=True)
        
        # Save the TTS output to the file
        tts.save(audio_path)
        
        # Play the audio
        play_audio(audio_path)
        
        print("Text to speech conversion successful.")
    else:
        print("No text to speak.")
