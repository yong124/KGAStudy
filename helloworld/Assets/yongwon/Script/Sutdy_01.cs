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
    string yongwon = "ㅁㄴㅇㄹ";
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
    // list 선언
    // list<데이터 타입> 리스트이름 = new List<데이터 타입>();
    //List<DataType> = name = new List<DataType>(new DataType[size])
    //ㄴ 빈 거 size 짜리 리스트를 만듬.
    //list도 생성과 동시에 초기화 해서 대입 가능
    //List<string>s ssh = new List<string>() {"신성호", "바보"}
    //ㄴ 이러면 ssh 리스트 안에 0번째는 "신성호" 1번째는 "바보"
    //ssh[0] = "신성호" , ssh[1] = "바보"
    //리스트는 다른 리스트를 받아서 대입할 수 있음
    //List<string> yyw = new List<string>(ssh);
    //ㄴ yyw == ssh는 true
    //리스트에 데이터 추가 하는 방법
    // Add 함수 이용
    // 얘는 리스트의 맨 뒤에 추가하는 방법임
    List<string> ssh = new List<string>() { "God 성호", "Good" };

        void Awake()
        {
            Debug.Log(test);

        }


        void Start()
        {
            ssh.Add("신성호우");
            //여기서는 ssh 초기화 후 별도로 값을 안 넣어놨어서
            //size가 0임(아무것도 없음)
            //그래서 " 신 성 호 우" 가 ssh[0]에 들어감
            ssh.Add("신 성 호 이");
            //추가한 " 신 성 호 이 " 는 ssh[1]에 위치

            //insert 함수 이용 방법
            // 말 그대로 끼워 넣는 방식임
            // 끼워 넣으니까 기존에 있떤 애들은 뒤로 밀림
            ssh.Insert(0, "유 용 워 이");
            // 이러면 ssh는?
            //[유용워이, 신성호우, 신성호이]
            //ssh.insert(3)

            //배열, 리스트의 크기를 구하는 방법
            //배열일 경우 
            //배열이름.Length;
            //리스트일 경우
            //리스트이름.Count;
            // 배열과 리스트의 크기를 구하는 방법이 다름
            // 방법이 다른데 리스트아ㅗ 배열의 이름을 비슷하게 지으면?
            // 배열이름.Count; 이렇게 하려고 해서 오류가 뜰 것임

            //리스트에서 데이터 삭제하는 방법
            // -Remove함수
            // 원하는 "값"을 찾아서 지움
            // 같은 값이 여러개면 맨 처음 값을 지우는데...
            // 같은 ID를 가지는 3마리 중 2번째를 지워야 하는 상황에서는?

            // - RemoveAt 함수 사용
            // 얘는 인덱스 정보로 지움.
            // 배열과 동일하게 0부터 시작

            // 이거 말고도 RemoveAll,Clear 함수가 있음.
            // 근데 안 쓸듯
            // RemoveAll 사용
            //리스트이름.RemoveAll(x=> x=='yyw');
            // x=>x =='yyw'이 부분은 람다식이라 하는데
            //몰라도 됨.
            //내용은 x가 yyw인 얘를 모두 지운다는 내용`

            //루아 구구단
            //for i = 1, i < = 9 do
            //  for j=1, j < = 9 do
            // print(i * j );

            //C#은 중괄호로 묶어줌
            /*        int sum=0 ;
                    for(int i=2; i<=9; i++)
                    {
                        for( int j =1; j<=9; j++)
                        {
                            Debug.Log(i+" x "+ j + " = " + i* j);
                            sum += i * j;
                            if (i * j % 2 == 1){
                                Debug.Log(i * j + "는 짝수얌");
                            }

                        }
                    }
            */

            // int 일 때 끝값을 포함하지 않음
            // 스위치
            // 얘도 조건에 따른 제어문임 (if랑 비슷)
            // 근데 얘는 하나의 값을 참조해서 일치하는 경우에만
            // 해당 명령어를 실행하는 방식
            // 비교, 논리 연산 불가
            // 정확히 일치하는 값이 있어야 쓸 수 있음

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

            Debug.Log("골드 :" + gold + " 에메랄드:" + emerald + " 루비:" + ruby);
            */
        
    }
}
