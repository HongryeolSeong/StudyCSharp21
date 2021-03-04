using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                AddressManager manager = new AddressManager()
                {
                    listAddress = new List<AddressInfo>()
                };

                DataFileManager filemanager = new DataFileManager();
                manager.listAddress = filemanager.ReadData();

                while (true) // 무한 반복
                {
                    Console.Clear();
                    manager.PrintMenu();
                    int menuNum = manager.SelectMenu();

                    switch (menuNum)
                    {
                        /*case 0: // 메뉴 선택 실패, 메뉴로 돌아감. default로 처리 가능
                            break;*/

                        case 1: // 1. 주소 입력 화면 전환
                            Console.Clear();
                            manager.InputAddress();
                            break;

                        case 2: // 2. 주소 검색 화면 전환
                            Console.Clear();
                            manager.SearchAddress();
                            break;

                        case 3: // 3. 주소 수정 화면 전환
                            Console.Clear();
                            manager.UpdateAddress();
                            break;

                        case 4: // 4. 주소 삭제 화면 전환
                            Console.Clear();
                            manager.DeleteAddress();
                            break;

                        case 5: // 5. 주소 전체 출력 화면 전환
                            Console.Clear();
                            manager.PrintAllAddress();
                            break;

                        case 6: // 6. 프로그램 종료
                                // 주소록을 다시 파일에 씀
                                // 실행파일과 같은 위치
                            filemanager.WriteData(manager.listAddress);
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
        }
    }
}
