using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour, Ipet
{
    //public GameObject objectPrefab;
    public void pet()
    {
        //   GameObject newObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);

        // �������������� �������� � ����� ��������, ���� ����������
        // ��������, ����� ���������� ��� �������, ������� ��� �������� ����������

        // ������ ��������� ������� � ��������
        // newObject.transform.position = new Vector3(0f, 0f, 0f);
        // newObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        Debug.Log("1");

    }
    public void OnMouseUp()
    {
       
    }

}
