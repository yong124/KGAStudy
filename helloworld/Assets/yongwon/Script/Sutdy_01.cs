using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class Sutdy_01 : MonoBehaviour
{
    public float speed;
    public Transform[] backgrounds;

    float leftPosX = 0f;
    float rightPosX = 0f;
    float xScreenHalfSize;
    float yScreenHalfSize;
    string yongwon = "��������";
    Vector2 startPoint = new Vector2(3, 5);
    int plus = 5 + 5;
    string test;
    int gold = 0, emerald = 0, ruby = 0;
    public TextMeshProUGUI goldValue;
    public TextMeshProUGUI emeraldValue;
    public TextMeshProUGUI rubyValue;

    public void OpenBox()
    {
        int goodsType = Random.Range(0, 3);
        int reward = Random.Range(1, 101);
        switch (goodsType)
        {
            case 0:
                gold += reward;
                break;
            case 1:
                emerald += reward;
                break;
            case 2:
                ruby += reward;
                break;
            default:
                break;
        }
        goldValue.text = "gold: " + gold;
        emeraldValue.text = "emerald: " + emerald;
        rubyValue.text = "ruby: " + ruby;
    }
    public void OpenBox100()
    {
        for(int i = 0; i < 100; i++) {
            OpenBox();
        }
    }

    // Start is called before the first frame update
    // list ����
    // list<������ Ÿ��> ����Ʈ�̸� = new List<������ Ÿ��>();
    //List<DataType> = name = new List<DataType>(new DataType[size])
    //�� �� �� size ¥�� ����Ʈ�� ����.
    //list�� ������ ���ÿ� �ʱ�ȭ �ؼ� ���� ����
    //List<string>s ssh = new List<string>() {"�ż�ȣ", "�ٺ�"}
    //�� �̷��� ssh ����Ʈ �ȿ� 0��°�� "�ż�ȣ" 1��°�� "�ٺ�"
    //ssh[0] = "�ż�ȣ" , ssh[1] = "�ٺ�"
    //����Ʈ�� �ٸ� ����Ʈ�� �޾Ƽ� ������ �� ����
    //List<string> yyw = new List<string>(ssh);
    //�� yyw == ssh�� true
    //����Ʈ�� ������ �߰� �ϴ� ���
    // Add �Լ� �̿�
    // ��� ����Ʈ�� �� �ڿ� �߰��ϴ� �����
    List<string> ssh = new List<string>() { "God ��ȣ", "Good" };

        void Awake()
        {
            Debug.Log(test);

        }


        void Start()
        {
            ssh.Add("�ż�ȣ��");
            //���⼭�� ssh �ʱ�ȭ �� ������ ���� �� �־���
            //size�� 0��(�ƹ��͵� ����)
            //�׷��� " �� �� ȣ ��" �� ssh[0]�� ��
            ssh.Add("�� �� ȣ ��");
            //�߰��� " �� �� ȣ �� " �� ssh[1]�� ��ġ

            //insert �Լ� �̿� ���
            // �� �״�� ���� �ִ� �����
            // ���� �����ϱ� ������ �ֶ� �ֵ��� �ڷ� �и�
            ssh.Insert(0, "�� �� �� ��");
            // �̷��� ssh��?
            //[�������, �ż�ȣ��, �ż�ȣ��]
            //ssh.insert(3)

            //�迭, ����Ʈ�� ũ�⸦ ���ϴ� ���
            //�迭�� ��� 
            //�迭�̸�.Length;
            //����Ʈ�� ���
            //����Ʈ�̸�.Count;
            // �迭�� ����Ʈ�� ũ�⸦ ���ϴ� ����� �ٸ�
            // ����� �ٸ��� ����Ʈ�Ƥ� �迭�� �̸��� ����ϰ� ������?
            // �迭�̸�.Count; �̷��� �Ϸ��� �ؼ� ������ �� ����

            //����Ʈ���� ������ �����ϴ� ���
            // -Remove�Լ�
            // ���ϴ� "��"�� ã�Ƽ� ����
            // ���� ���� �������� �� ó�� ���� ����µ�...
            // ���� ID�� ������ 3���� �� 2��°�� ������ �ϴ� ��Ȳ������?

            // - RemoveAt �Լ� ���
            // ��� �ε��� ������ ����.
            // �迭�� �����ϰ� 0���� ����

            // �̰� ���� RemoveAll,Clear �Լ��� ����.
            // �ٵ� �� ����
            // RemoveAll ���
            //����Ʈ�̸�.RemoveAll(x=> x=='yyw');
            // x=>x =='yyw'�� �κ��� ���ٽ��̶� �ϴµ�
            //���� ��.
            //������ x�� yyw�� �긦 ��� ����ٴ� ����`

            //��� ������
            //for i = 1, i < = 9 do
            //  for j=1, j < = 9 do
            // print(i * j );

            //C#�� �߰�ȣ�� ������
            /*        int sum=0 ;
                    for(int i=2; i<=9; i++)
                    {
                        for( int j =1; j<=9; j++)
                        {
                            Debug.Log(i+" x "+ j + " = " + i* j);
                            sum += i * j;
                            if (i * j % 2 == 1){
                                Debug.Log(i * j + "�� ¦����");
                            }

                        }
                    }
            */

            // int �� �� ������ �������� ����
            // ����ġ
            // �굵 ���ǿ� ���� ����� (if�� ���)
            // �ٵ� ��� �ϳ��� ���� �����ؼ� ��ġ�ϴ� ��쿡��
            // �ش� ��ɾ �����ϴ� ���
            // ��, �� ���� �Ұ�
            // ��Ȯ�� ��ġ�ϴ� ���� �־�� �� �� ����

            /*
            for (int i = 0; i < 101; i++)
            {
                int goodsType = Random.Range(0, 3);
                int reward = Random.Range(1, 101);
                switch (goodsType)
                {
                    case 0:
                        gold += reward;
                        break;
                    case 1:
                        emerald += reward;
                        break;
                    case 2:
                        ruby += reward;
                        break;
                    default:
                        break;
                }
            }

            Debug.Log("��� :" + gold + " ���޶���:" + emerald + " ���:" + ruby);
            */
        
    }
}
