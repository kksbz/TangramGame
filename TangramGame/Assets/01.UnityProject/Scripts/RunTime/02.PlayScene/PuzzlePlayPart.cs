using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//마우스 버튼 드래그, 업, 다운 사용하기위한 인터페이스 상속
public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler, IPointerUpHandler , IPointerMoveHandler
{
    private bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //마우스 버튼을 눌렀을 때 동작하는 함수
    public void OnPointerDown(PointerEventData eventData)
    {
        isClicked = true;
        // Debug:
        // GFunc.Log($"{gameObject.name}을 선택했다.");
    } //OnPointerDown

    //마우스 버튼에서 손을 뗐을 때 동작하는 함수
    public void OnPointerUp(PointerEventData eventData)
    {
        isClicked = false;
        // Debug:
        // GFunc.Log($"{gameObject.name}을 선택 해제했다.");
    } //OnPointerUp

    //마우스를 드래그 중일 때 동작하는 함수
    public void OnPointerMove(PointerEventData eventData)
    {
        //현재 오브젝트를 선택한 경우
        if(isClicked == true)
        {
            GFunc.Log($"마우스의 포지션을 눈으로 확인 : {eventData.position.x}, {eventData.position.y}");
        }
    } //OnPointerMove
}
