using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public Text confirmationText;

    public void OnButtonClick()
    {
        // ��ư Ŭ�� �� ������ ������ �� �Լ��� �����մϴ�.
        ShowConfirmation();
    }

    void ShowConfirmation()
    {
        // ��ư Ŭ�� �� "���� Ȯ��" â�� ǥ���մϴ�.
        if (confirmationText != null)
        {
            confirmationText.text = "���� Ȯ�� â�� ǥ���մϴ�.";
        }
    }
}
