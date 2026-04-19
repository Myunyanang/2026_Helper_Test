using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] NoteController noteController;

    void Start()
    {

    }

    void Update()
    {

    }

    public void InputButton1()
    {
        noteController.checkNoteLineNum = 1;
    }

    public void InputButton2()
    {
        noteController.checkNoteLineNum = 2;
    }

    public void InputButton3()
    {
        noteController.checkNoteLineNum = 3;
    }

    public void InputButton4()
    {
        noteController.checkNoteLineNum = 4;
    }

    //노트컨트롤러에서 생성시 노트라인번호+해당번호의 리스트 등록을 시킴.
    //버튼이 눌렸을 때 해당 라인의 가장 먼저 등록된 노트를 체크함.
    //이 떄 조건에 맞으면 참조된 값을 수정할 수 있으니까 해당 체크한 오브젝트의 노트컨트롤러 스크립트에서 확인 시점에서 바로 인풋값을 저장함.
}
