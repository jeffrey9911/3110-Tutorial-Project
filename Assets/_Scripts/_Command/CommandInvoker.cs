using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    PlayerAction inputAction;

    static Queue<iCommand> commandBuffer;

    static List<iCommand> commandHistory;

    static int counter;

    private void Start()
    {
        commandBuffer = new Queue<iCommand>();
        commandHistory = new List<iCommand>();

        inputAction = PlayerInputController.controller.inputAction;

        inputAction.Editor.Undo.performed += cntxt => UndoCommand();
    }

    private void UndoCommand()
    {

    }

}
