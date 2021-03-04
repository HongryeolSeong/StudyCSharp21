using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    // 주소록 정보 클래스
    class AddressInfo
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            List<AddressInfo> listAddress = new List<AddressInfo>(); // 주소록 담을 컬렉션 생성

            while (true) // 무한 반복
            {
                Console.Clear();
                // 메뉴 출력
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1. 주소 입력");
                Console.WriteLine("2. 주소 검색");
                Console.WriteLine("3. 주소 수정");
                Console.WriteLine("4. 주소 삭제");
                Console.WriteLine("5. 주소 전체 출력");
                Console.WriteLine("6. 프로그램 종료");
                Console.WriteLine("--------------------------------------------------");
                // 메뉴 번호 입력
                Console.Write("메뉴를 선택하세요 >>> ");
                string input = Console.ReadLine();
                int.TryParse(input, out int menuNum);

                if (!(menuNum > 0 && menuNum < 7))
                {
                    menuNum = 0;
                }
                //Console.WriteLine($"선택된 메뉴 : {menuNum}");


                switch (menuNum)
                {
                    /*case 0: // 메뉴 선택 실패, 메뉴로 돌아감. default로 처리 가능
                        break;*/ 

                    case 1: // 1. 주소 입력 화면 전환
                        Console.Clear();
                        Console.WriteLine("주소 입력");
                        Console.WriteLine("--------------------------------------------------");
                        Console.Write("이름 입력 : ");
                        string name = Console.ReadLine();
                        Console.Write("전화 입력 : ");
                        string phone = Console.ReadLine();
                        Console.Write("주소 입력 : ");
                        string address = Console.ReadLine();

                        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
                        {
                            Console.WriteLine("빈 값은 입력할 수 없습니다.");
                            Console.ReadLine();
                        }
                        else
                        {
                            listAddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address });
                        }
                        break;

                    case 2: // 2. 주소 검색 화면 전환
                        Console.Clear();
                        Console.WriteLine("주소 검색");
                        Console.WriteLine("--------------------------------------------------");
                        Console.Write("이름 입력 : ");
                        string name2 = Console.ReadLine();
                        int idx = 0;
                        bool isFind = false; // 찾는 이름이 있는지?
                        foreach (var item in listAddress)
                        {
                            if (item.Name == name2)
                            {
                                isFind = true; // 찾았음
                                Console.WriteLine($"[{idx}]------------------------------------------");
                                Console.WriteLine($"이름 : {item.Name}");
                                Console.WriteLine($"전화 : {item.Phone}");
                                Console.WriteLine($"주소 : {item.Address}");
                                Console.WriteLine("--------------------------------------------------");
                                break; // foreach 빠져나감
                            }
                            idx++;
                            
                        }

                        if (isFind == false)
                        {
                            Console.WriteLine("검색 결과가 없습니다 ㅜㅜ");
                        }

                        Console.ReadLine(); // 화면 한 번 멈추기 위해
                        break;

                    case 3: // 3. 주소 수정 화면 전환
                        Console.Clear();
                        Console.WriteLine("주소 수정");
                        Console.WriteLine("--------------------------------------------------");
                        Console.Write("이름 입력 : ");
                        string name5 = Console.ReadLine();
                        int idx5 = 0;
                        bool isFind2 = false;
                        foreach (var item in listAddress)
                        {
                            if (item.Name == name5)
                            {
                                isFind2 = true;
                                Console.WriteLine($"[{idx5}]-----------------------------------------");
                                Console.WriteLine($"이름 : {item.Name}");
                                Console.WriteLine($"전화 : {item.Phone}");
                                Console.WriteLine($"주소 : {item.Address}");
                                Console.WriteLine("--------------------------------------------------");
                                Console.Write("이름 재입력 : ");
                                string uName = Console.ReadLine();
                                Console.Write("전화 재입력 : ");
                                string uPhone = Console.ReadLine();
                                Console.Write("주소 재입력 : ");
                                string uAddress = Console.ReadLine();

                                item.Name = uName;
                                item.Phone = uPhone;
                                item.Address = uAddress;
                                break; // foreach 빠져나감
                            }
                            idx5++;
                        }

                        if (isFind2 == false)
                        {
                            Console.WriteLine("검색 결과가 없습니다 ㅜㅜ");
                        }

                        Console.ReadLine(); // 화면 한 번 멈추기 위해
                        break;

                    case 4: // 4. 주소 삭제 화면 전환
                        Console.Clear();
                        Console.WriteLine("주소 삭제");
                        Console.WriteLine("--------------------------------------------------");
                        Console.Write("이름 입력 : ");
                        string name3 = Console.ReadLine();
                        int idx2 = 0;
                        bool isFind3 = false;
                        foreach (var item in listAddress)
                        {
                            if (item.Name == name3)
                            {
                                isFind3 = true;
                                Console.WriteLine($"[{idx2}]-----------------------------------------");
                                Console.WriteLine($"이름 : {item.Name}");
                                Console.WriteLine($"전화 : {item.Phone}");
                                Console.WriteLine($"주소 : {item.Address}");
                                Console.WriteLine("--------------------------------------------------");
                                Console.Write("삭제하시겠습니까? [y/n]");
                                string answer = Console.ReadLine(); // 응답 입력
                                if (answer.ToUpper() == "Y")
                                {
                                    listAddress.RemoveAt(idx2);
                                    Console.WriteLine("삭제 완료");
                                }
                                break; // foreach 빠져나감
                            }
                            idx2++;
                        }

                        if (isFind3 == false)
                        {
                            Console.WriteLine("검색 결과가 없습니다 ㅜㅜ");
                        }

                        Console.ReadLine(); // 화면 한 번 멈추기 위해
                        break;

                    case 5: // 5. 주소 전체 출력 화면 전환
                        Console.Clear();
                        Console.WriteLine("주소 전체 출력");
                        Console.WriteLine("--------------------------------------------------");
                        int idx3 = 0;

                        if (listAddress.Count == 0)
                        {
                            Console.WriteLine("주소록이 없습니다.");
                        }
                        else
                        {
                            foreach (var item in listAddress)
                            {
                                Console.WriteLine($"[{idx3}]------------------------------------------");
                                Console.WriteLine($"이름 : {item.Name}");
                                Console.WriteLine($"전화 : {item.Phone}");
                                Console.WriteLine($"주소 : {item.Address}");
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine();
                                idx3++;
                            }
                        }
                        
                        Console.ReadLine(); // 화면 한 번 멈추기 위해
                        break;

                    case 6: // 6. 프로그램 종료 화면 전환
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
