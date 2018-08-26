# Unity - Undo Redo System #

Undo Redo system implementation in Unity uGUI system. <br/><br/>

## API ##
```
// Call undo for whole program.
GetComponent<JCS_UndoRedoSystem>().UndoComponent();

// Call redo for whole program.
GetComponent<JCS_UndoRedoSystem>().RedoComponent();

// Call undo for just one single component.
GetComponent<JCS_UndoRedoComponent>().Undo();

// Call redo for just one single component.
GetComponent<JCS_UndoRedoComponent>().Redo();
```

## Screenshot ##
<img src="./screenshot/undo_redo_demo.gif"/>

## 3rd Party Source ##
* JCSUnity : https://github.com/jcs090218/JCSUnity by <a href="https://github.com/jcs090218">Jen-Chieh Shen</a>
