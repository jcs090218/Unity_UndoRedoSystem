[![Build Status](https://travis-ci.com/jcs090218/Unity_UndoRedoSystem.svg?branch=master)](https://travis-ci.com/jcs090218/Unity_UndoRedoSystem)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)

# Unity - Undo Redo System

Undo Redo system implementation in Unity uGUI system.

## Supported UI

* Input Field
* Dropdown
* Toggle
* Scrollbar
* Slider

## API

### Undo Redo System

```cs
JCS_UndoRedoSystem urs = this.GetComponent<JCS_UndoRedoSystem>();

// Do undo once from this system if any.
urs.UndoComponent();

// Do redo once from this system if any.
urs.RedoComponent();

// Stop recording undo/redo action to all the component control 
// by this undo/redo system.
urs.StopRecrodingAll();

// Start recording undo/redo action to all the component control 
// by this undo/redo system.
urs.StartRecrodingAll();

// Record initialize data once to all undo/redo component.
urs.RecordPrevData();

/* Clear history */
{
    // Clear all undo history.
    urs.ClearUndoComp();

    // Clear all redo history.
    urs.ClearRedoComp();

    // Clear all the undo redo history data.
    urs.ClearAllUndoRedoHistory();
}

/* Check for undo redo action exists? */
{
    // Check if there is at least one undo history?
    bool undoData = urs.ThereIsUndoHistory();

    // Check if there is at least one redo history?
    bool redoData = urs.ThereIsRedoHistory();

    // Check if there is at least one undo/redo history?
    bool undoRedoData = urs.ThereIsUndoOrRedoHistory();
}
```

### Undo Redo Component

```cs
JCS_UndoRedoComponent urc = this.GetComponent<JCS_UndoRedoComponent>();

// Do one undo to this component.
urc.Undo();

// Dp one redo to this component.
urc.Redo();

// Stop recording undo/redo action starting from this moment.
urc.StopRecording();

// Start recording undo/redo action starting from this moment.
urc.StartRecording();

// Is the current component recording undo/redo action now?
bool isRecording = urc.IsRecording();

// If the UI value have changed by script at initialize time 
// but the undo/redo component did not get the correct default 
// data from the UI call this manually will record down the UI 
// starting value.
urc.RecordPrevData();

/* Clear history */
{
    // Clear all undo history to this component.
    urc.ClearAllUndo();
    
    // Clear all redo history to this component.
    urc.ClearAllRedo();
    
    // Clear all undo and redo history to this component.
    urc.ClearAllUndoRedoHistory();
}
```

## Screenshot

<img src="./screenshot/undo_redo_demo.gif"/>

## 3rd Party Source

* JCSUnity : https://github.com/jcs090218/JCSUnity by <a href="https://github.com/jcs090218">Jen-Chieh Shen</a>
