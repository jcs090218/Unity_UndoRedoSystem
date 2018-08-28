# Unity - Undo Redo System #

Undo Redo system implementation in Unity uGUI system. <br/><br/>


## Supported UI ##
* Input Field
* Dropdown
* Toggle
* Scrollbar
* Slider


## API ##
```
/* For undo/redo system. */
{
    GetComponent<JCS_UndoRedoSystem>().UndoComponent();

    GetComponent<JCS_UndoRedoSystem>().RedoComponent();
    
    // Stop recording undo/redo action from all undo/redo 
    // components under this system.
    GetComponent<JCS_UndoRedoSystem>().StopRecroding();
    
    // Start recording undo/redo action from all undo/redo 
    // components under this system.
    GetComponent<JCS_UndoRedoSystem>().StartRecroding();
    
    // Record initialize data once to all undo/redo component.
    GetComponent<JCS_UndoRedoSystem>().RecordPrevData();
}

/* For single undo/redo component. */
{
    GetComponent<JCS_UndoRedoComponent>().Undo();

    GetComponent<JCS_UndoRedoComponent>().Redo();
    
    // Stop recording undo/redo action starting from this moment.
    GetComponent<JCS_UndoRedoComponent>().StopRecording();
    
    // Start recording undo/redo action starting from this moment.
    GetComponent<JCS_UndoRedoComponent>().StartRecording();
    
    // Is the current component recording undo/redo action now?
    bool isRecording = GetComponent<JCS_UndoRedoComponent>().IsRecording();
    
    // If the UI value have changed by script at initialize time 
    // but the undo/redo component did not get the correct default 
    // data from the UI call this manually will record down the UI 
    // starting value.
    GetComponent<JCS_UndoRedoComponent>().RecordPrevData();
}
```

## Screenshot ##
<img src="./screenshot/undo_redo_demo.gif"/>


## 3rd Party Source ##
* JCSUnity : https://github.com/jcs090218/JCSUnity by <a href="https://github.com/jcs090218">Jen-Chieh Shen</a>
