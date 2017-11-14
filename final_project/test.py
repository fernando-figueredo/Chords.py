import sys
from neural_network.classifier import Classifier

classifier = Classifier()
file_path = sys.argv[1] if len(sys.argv) > 1 else "hand-made-chords/c.wav"
classifier.classify(file_path)

