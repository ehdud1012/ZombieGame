using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public Text confirmationText;

    public void OnButtonClick()
    {
        // 버튼 클릭 시 실행할 내용을 이 함수에 구현합니다.
        ShowConfirmation();
    }

    void ShowConfirmation()
    {
        // 버튼 클릭 시 "구매 확인" 창을 표시합니다.
        if (confirmationText != null)
        {
            confirmationText.text = "구매 확인 창을 표시합니다.";
        }
    }
}
