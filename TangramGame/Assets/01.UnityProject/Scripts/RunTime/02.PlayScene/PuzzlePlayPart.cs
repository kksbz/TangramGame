using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//마우스 버튼 드래그, 업, 다운 사용하기위한 인터페이스 상속
public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler, IPointerUpHandler , IDragHandler
{
    private bool isClicked = false;
    private RectTransform objRect = default;
    private PuzzleInitZone puzzleInitZone = default;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        objRect = gameObject.GetRect();
        puzzleInitZone = transform.parent.gameObject.GetComponent<PuzzleInitZone>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //마우스 버튼을 눌렀을 때 동작하는 함수
    public void OnPointerDown(PointerEventData eventData)
    {
        isClicked = true;
    } //OnPointerDown

    //마우스 버튼에서 손을 뗐을 때 동작하는 함수
    public void OnPointerUp(PointerEventData eventData)
    {
        isClicked = false;
    } //OnPointerUp

    //마우스를 드래그 중일 때 동작하는 함수
    public void OnDrag(PointerEventData eventData)
    {
        //현재 오브젝트를 선택한 경우
        if(isClicked == true)
        {
            gameObject.AddAnchoredPos(eventData.delta / puzzleInitZone.parentCanvas.scaleFactor);
        }
        
    } //OnPointerMove
}
