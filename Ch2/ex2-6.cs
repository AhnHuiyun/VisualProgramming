//using System;
///// <summary>
///// CommentsApp Class : Convert a hexadigit into binary value
///// </summary>
//class CommentsApp
//{
//    /// <summary>
//    /// Main Method
//    /// </summary>
//    public static void Main()
//    {
//        int value = 0;
//        char ch;
//        Console.Write("Enter a super digit : "); // prompt message
//        ch = (char)Console.Read();
//        switch (ch)
//        {
//            case 'A':
//            case 'B':
//            case 'C':
//            case 'D':
//            case 'E':
//            case 'F':
//                value = ch - 'A' + 10; // code value => binary value
//                break;
//            case 'a':
//            case 'b':
//            case 'c':
//            case 'd':
//            case 'e':
//            case 'f':
//                value = ch - 'a' + 10; // code value => binary value
//                break;
//            default:
//                Console.WriteLine(ch + " is not a hexadigit");
//                break;
//        } // end of switch
//        Console.WriteLine(value);
//    } // end of main()
//}
////프로젝트->속성->빌드*->XML문서파일 원하는 XML파일 지정