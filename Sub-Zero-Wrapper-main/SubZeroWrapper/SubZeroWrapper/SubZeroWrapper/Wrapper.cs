using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubZeroWrapper
{
    class Instructions
    {
        public static string a1 = ".";
        public static string a2 = "|";
        public static string a3 = ":";
        public static string a4 = "/";
        public static string a5 = "!";
        public static string a6 = "@";
        public static string a7 = "#";
        public static string a8 = "$";
        public static string a9 = "%";
        public static string a10 = "^";
        public static string a11 = "&";
        public static string a12 = "*";
        public static string a13 = "(";
        public static string a14 = ")";
        public static string a15 = "[";
        public static string a16 = "]";
        public static string a17 = "{";
        public static string a18 = "}";
        public static string a19 = "0x28";
        public static string a20 = "+";
        public static string a21 = "?";
        public static string a22 = "<";
        public static string a23 = ">";
        public static string a24 = "=";
        public static string a25 = "-";
        public static string a26 = "_";
        public static string a27 = ",";
        public static string a28 = "'";
        public static string a29 = "\"";
        public static string a30 = "`";
        public static string a31 = "~";
        public static string a32 = "1";
        public static string a33 = "2";
        public static string a34 = "3";
        public static string a35 = "4";
        public static string a36 = "5";
        public static string a37 = "6";
        public static string a38 = "7";
        public static string a39 = "8";
        public static string a40 = "9";
        public static string a41 = "0";
        public static string a42 = "A";
        public static string a43 = "B";
        public static string a44 = "C";
        public static string a45 = "D";
        public static string a46 = "E";
        public static string a47 = "F";
        public static string a48 = "G";
        public static string a49 = "H";
        public static string a50 = "I";
        public static string a51 = "J";
        public static string a52 = "K";
        public static string a53 = "L";
        public static string a54 = "M";
        public static string a55 = "N";
        public static string a56 = "O";
        public static string a57 = "P";
        public static string a58 = "Q";
        public static string a59 = "R";
        public static string a60 = "S";
        public static string a61 = "T";
        public static string a62 = "U";
        public static string a63 = "V";
        public static string a64 = "W";
        public static string a65 = "X";
        public static string a66 = "Y";
        public static string a67 = "Z";
        public static string a68 = "a";
        public static string a69 = "b";
        public static string a70 = "c";
        public static string a71 = "d";
        public static string a72 = "e";
        public static string a73 = "f";
        public static string a74 = "g";
        public static string a75 = "h";
        public static string a76 = "i";
        public static string a77 = "j";
        public static string a78 = "k";
        public static string a79 = "l";
        public static string a80 = "m";
        public static string a81 = "n";
        public static string a82 = "o";
        public static string a83 = "p";
        public static string a84 = "q";
        public static string a85 = "r";
        public static string a86 = "s";
        public static string a87 = "t";
        public static string a88 = "u";
        public static string a89 = "v";
        public static string a90 = "w";
        public static string a91 = "x";
        public static string a92 = "y";
        public static string a93 = "z";
        public static string a94 = " ";
        public static string a95 = "MultiThread";
    }

    class Wrapper
    {
        public static List<string> Wrap = new List<string>();

        public static List<string> UnWrap = new List<string>();

        public static int __index = 0;

        public static string WrapEnv(string input)
        {
            string input1 = "";
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case '.':
                        {
                            Wrap.Add(input1 += Instructions.a1);
                            break;
                        }
                    case '|':
                        {
                            Wrap.Add(input1 += Instructions.a2);
                            break;
                        }
                    case ':':
                        {
                            Wrap.Add(input1 += Instructions.a3);
                            break;
                        }
                    case '/':
                        {
                            Wrap.Add(input1 += Instructions.a4);
                            break;
                        }
                    case '!':
                        {
                            Wrap.Add(input1 += Instructions.a5);
                            break;
                        }
                    case '@':
                        {
                            Wrap.Add(input1 += Instructions.a6);
                            break;
                        }
                    case '#':
                        {
                            Wrap.Add(input1 += Instructions.a7);
                            break;
                        }
                    case '$':
                        {
                            Wrap.Add(input1 += Instructions.a8);
                            break;
                        }
                    case '%':
                        {
                            Wrap.Add(input1 += Instructions.a9);
                            break;
                        }
                    case '^':
                        {
                            Wrap.Add(input1 += Instructions.a10);
                            break;
                        }
                    case '&':
                        {
                            Wrap.Add(input1 += Instructions.a11);
                            break;
                        }
                    case '*':
                        {
                            Wrap.Add(input1 += Instructions.a12);
                            break;
                        }
                    case '(':
                        {
                            Wrap.Add(input1 += Instructions.a13);
                            break;
                        }
                    case ')':
                        {
                            Wrap.Add(input1 += Instructions.a14);
                            break;
                        }
                    case '[':
                        {
                            Wrap.Add(input1 += Instructions.a15);
                            break;
                        }
                    case ']':
                        {
                            Wrap.Add(input1 += Instructions.a16);
                            break;
                        }
                    case '{':
                        {
                            Wrap.Add(input1 += Instructions.a17);
                            break;
                        }
                    case '}':
                        {
                            Wrap.Add(input1 += Instructions.a18);
                            break;
                        }
                    case ';':
                        {
                            Wrap.Add(input1 += Instructions.a19);
                            break;
                        }
                    case '+':
                        {
                            Wrap.Add(input1 += Instructions.a20);
                            break;
                        }
                    case '?':
                        {
                            Wrap.Add(input1 += Instructions.a21);
                            break;
                        }
                    case '<':
                        {
                            Wrap.Add(input1 += Instructions.a22);
                            break;
                        }
                    case '>':
                        {
                            Wrap.Add(input1 += Instructions.a23);
                            break;
                        }
                    case '=':
                        {
                            Wrap.Add(input1 += Instructions.a24);
                            break;
                        }
                    case '-':
                        {
                            Wrap.Add(input1 += Instructions.a25);
                            break;
                        }
                    case '_':
                        {
                            Wrap.Add(input1 += Instructions.a26);
                            break;
                        }
                    case ',':
                        {
                            Wrap.Add(input1 += Instructions.a27);
                            break;
                        }
                    case '\'':
                        {
                            Wrap.Add(input1 += Instructions.a28);
                            break;
                        }
                    case '\"':
                        {
                            Wrap.Add(input1 += Instructions.a29);
                            break;
                        }
                    case '`':
                        {
                            Wrap.Add(input1 += Instructions.a30);
                            break;
                        }
                    case '~':
                        {
                            Wrap.Add(input1 += Instructions.a31);
                            break;
                        }
                    case '1':
                        {
                            Wrap.Add(input1 += Instructions.a32);
                            break;
                        }
                    case '2':
                        {
                            Wrap.Add(input1 += Instructions.a33);
                            break;
                        }
                    case '3':
                        {
                            Wrap.Add(input1 += Instructions.a34);
                            break;
                        }
                    case '4':
                        {
                            Wrap.Add(input1 += Instructions.a35);
                            break;
                        }
                    case '5':
                        {
                            Wrap.Add(input1 += Instructions.a36);
                            break;
                        }
                    case '6':
                        {
                            Wrap.Add(input1 += Instructions.a37);
                            break;
                        }
                    case '7':
                        {
                            Wrap.Add(input1 += Instructions.a38);
                            break;
                        }
                    case '8':
                        {
                            Wrap.Add(input1 += Instructions.a39);
                            break;
                        }
                    case '9':
                        {
                            Wrap.Add(input1 += Instructions.a40);
                            break;
                        }
                    case '0':
                        {
                            Wrap.Add(input1 += Instructions.a41);
                            break;
                        }
                    case 'A':
                        {
                            Wrap.Add(input1 += Instructions.a42);
                            break;
                        }
                    case 'B':
                        {
                            Wrap.Add(input1 += Instructions.a43);
                            break;
                        }
                    case 'C':
                        {
                            Wrap.Add(input1 += Instructions.a44);
                            break;
                        }
                    case 'D':
                        {
                            Wrap.Add(input1 += Instructions.a45);
                            break;
                        }
                    case 'E':
                        {
                            Wrap.Add(input1 += Instructions.a46);
                            break;
                        }
                    case 'F':
                        {
                            Wrap.Add(input1 += Instructions.a47);
                            break;
                        }
                    case 'G':
                        {
                            Wrap.Add(input1 += Instructions.a48);
                            break;
                        }
                    case 'H':
                        {
                            Wrap.Add(input1 += Instructions.a49);
                            break;
                        }
                    case 'I':
                        {
                            Wrap.Add(input1 += Instructions.a50);
                            break;
                        }
                    case 'J':
                        {
                            Wrap.Add(input1 += Instructions.a51);
                            break;
                        }
                    case 'K':
                        {
                            Wrap.Add(input1 += Instructions.a52);
                            break;
                        }
                    case 'L':
                        {
                            Wrap.Add(input1 += Instructions.a53);
                            break;
                        }
                    case 'M':
                        {
                            Wrap.Add(input1 += Instructions.a54);
                            break;
                        }
                    case 'N':
                        {
                            Wrap.Add(input1 += Instructions.a55);
                            break;
                        }
                    case 'O':
                        {
                            Wrap.Add(input1 += Instructions.a56);
                            break;
                        }
                    case 'P':
                        {
                            Wrap.Add(input1 += Instructions.a57);
                            break;
                        }
                    case 'Q':
                        {
                            Wrap.Add(input1 += Instructions.a58);
                            break;
                        }
                    case 'R':
                        {
                            Wrap.Add(input1 += Instructions.a59);
                            break;
                        }
                    case 'S':
                        {
                            Wrap.Add(input1 += Instructions.a60);
                            break;
                        }
                    case 'T':
                        {
                            Wrap.Add(input1 += Instructions.a61);
                            break;
                        }
                    case 'U':
                        {
                            Wrap.Add(input1 += Instructions.a62);
                            break;
                        }
                    case 'V':
                        {
                            Wrap.Add(input1 += Instructions.a63);
                            break;
                        }
                    case 'W':
                        {
                            Wrap.Add(input1 += Instructions.a64);
                            break;
                        }
                    case 'X':
                        {
                            Wrap.Add(input1 += Instructions.a65);
                            break;
                        }
                    case 'Y':
                        {
                            Wrap.Add(input1 += Instructions.a66);
                            break;
                        }
                    case 'Z':
                        {
                            Wrap.Add(input1 += Instructions.a67);
                            break;
                        }
                    case 'a':
                        {
                            Wrap.Add(input1 += Instructions.a68);
                            break;
                        }
                    case 'b':
                        {
                            Wrap.Add(input1 += Instructions.a69);
                            break;
                        }
                    case 'c':
                        {
                            Wrap.Add(input1 += Instructions.a70);
                            break;
                        }
                    case 'd':
                        {
                            Wrap.Add(input1 += Instructions.a71);
                            break;
                        }
                    case 'e':
                        {
                            Wrap.Add(input1 += Instructions.a72);
                            break;
                        }
                    case 'f':
                        {
                            Wrap.Add(input1 += Instructions.a73);
                            break;
                        }
                    case 'g':
                        {
                            Wrap.Add(input1 += Instructions.a74);
                            break;
                        }
                    case 'h':
                        {
                            Wrap.Add(input1 += Instructions.a75);
                            break;
                        }
                    case 'i':
                        {
                            Wrap.Add(input1 += Instructions.a76);
                            break;
                        }
                    case 'j':
                        {
                            Wrap.Add(input1 += Instructions.a77);
                            break;
                        }
                    case 'k':
                        {
                            Wrap.Add(input1 += Instructions.a78);
                            break;
                        }
                    case 'l':
                        {
                            Wrap.Add(input1 += Instructions.a79);
                            break;
                        }
                    case 'm':
                        {
                            Wrap.Add(input1 += Instructions.a80);
                            break;
                        }
                    case 'n':
                        {
                            Wrap.Add(input1 += Instructions.a81);
                            break;
                        }
                    case 'o':
                        {
                            Wrap.Add(input1 += Instructions.a82);
                            break;
                        }
                    case 'p':
                        {
                            Wrap.Add(input1 += Instructions.a83);
                            break;
                        }
                    case 'q':
                        {
                            Wrap.Add(input1 += Instructions.a84);
                            break;
                        }
                    case 'r':
                        {
                            Wrap.Add(input1 += Instructions.a85);
                            break;
                        }
                    case 's':
                        {
                            Wrap.Add(input1 += Instructions.a86);
                            break;
                        }
                    case 't':
                        {
                            Wrap.Add(input1 += Instructions.a87);
                            break;
                        }
                    case 'u':
                        {
                            Wrap.Add(input1 += Instructions.a88);
                            break;
                        }
                    case 'v':
                        {
                            Wrap.Add(input1 += Instructions.a89);
                            break;
                        }
                    case 'w':
                        {
                            Wrap.Add(input1 += Instructions.a90);
                            break;
                        }
                    case 'x':
                        {
                            Wrap.Add(input1 += Instructions.a91);
                            break;
                        }
                    case 'y':
                        {
                            Wrap.Add(input1 += Instructions.a92);
                            break;
                        }
                    case 'z':
                        {
                            Wrap.Add(input1 += Instructions.a93);
                            break;
                        }
                    case ' ':
                        {
                            Wrap.Add(input1 += Instructions.a94);
                            break;
                        }
                }
            }
            return input1;
        }

        public static string RegisterFunction(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = name;
            resourcePath = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith(name));

            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        
        private static void UnWrapEnv()
        {
            UnWrap.Add(Instructions.a41);
            UnWrap.Add(Instructions.a91);
            UnWrap.Add(Instructions.a64);
            UnWrap.Add(Instructions.a85);
            UnWrap.Add(Instructions.a68);
            UnWrap.Add(Instructions.a83);
        }

        private static string MTTasks(string input, int MTTasksCount)
        {
            if (MTTasksCount == 0)
            {
                return "";
            }
            else if (MTTasksCount < 0)
            {
                return "";
            }
            else if (MTTasksCount > 0)
            {
                string input1 = WrapEnv(input);
                return input1;
            }
            else
            {
                return "";
            }
        }

        public static bool IsInWrappedEnv(string input)
        {
            foreach (string item in Wrap)
            {
                if (item.Contains(input))
                {
                    return true;
                }
            }
            return false;
        }

        public static string WrapMT()
        {
            int WrappedEnvCount = Wrap.Count();
            string __table = System.Convert.ToString(__index * WrappedEnvCount);
            string __subindex = System.Convert.ToString(__index / WrappedEnvCount);
            Wrap.Add(__index++.ToString());
            Wrap.Add(__index--.ToString());
            Wrap.Add(__table);
            Wrap.Add(__subindex);
            Wrap.Add(__table + __index);
            Wrap.Add(__subindex + __table);
            UnWrapEnv();
            string UnWrap1 = string.Join("", UnWrap);
            string output = Instructions.a95 + UnWrap1;
            UnWrap.Clear();
            int i = 0;
            i++;
            string output1 = MTTasks(output, i);
            return output1;
        }
    }

    public class AddyCompiler
    {
        public static string Compile(string input)
        {
            string input1 = "";
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case '.':
                        {
                            Wrapper.Wrap.Add(input1 += "0x01");
                            break;
                        }
                    case '|':
                        {
                            Wrapper.Wrap.Add(input1 += "0x02");
                            break;
                        }
                    case ':':
                        {
                            Wrapper.Wrap.Add(input1 += "0x03");
                            break;
                        }
                    case '/':
                        {
                            Wrapper.Wrap.Add(input1 += "0x04");
                            break;
                        }
                    case '!':
                        {
                            Wrapper.Wrap.Add(input1 += "0x05");
                            break;
                        }
                    case '@':
                        {
                            Wrapper.Wrap.Add(input1 += "0x06");
                            break;
                        }
                    case '#':
                        {
                            Wrapper.Wrap.Add(input1 += "0x07");
                            break;
                        }
                    case '$':
                        {
                            Wrapper.Wrap.Add(input1 += "0x08");
                            break;
                        }
                    case '%':
                        {
                            Wrapper.Wrap.Add(input1 += "0x09");
                            break;
                        }
                    case '^':
                        {
                            Wrapper.Wrap.Add(input1 += "0x10");
                            break;
                        }
                    case '&':
                        {
                            Wrapper.Wrap.Add(input1 += "0x11");
                            break;
                        }
                    case '*':
                        {
                            Wrapper.Wrap.Add(input1 += "0x12");
                            break;
                        }
                    case '(':
                        {
                            Wrapper.Wrap.Add(input1 += "0x13");
                            break;
                        }
                    case ')':
                        {
                            Wrapper.Wrap.Add(input1 += "0x14");
                            break;
                        }
                    case '[':
                        {
                            Wrapper.Wrap.Add(input1 += "0x15");
                            break;
                        }
                    case ']':
                        {
                            Wrapper.Wrap.Add(input1 += "0x16");
                            break;
                        }
                    case '{':
                        {
                            Wrapper.Wrap.Add(input1 += "0x17");
                            break;
                        }
                    case '}':
                        {
                            Wrapper.Wrap.Add(input1 += "0x18");
                            break;
                        }
                    case ';':
                        {
                            Wrapper.Wrap.Add(input1 += "0x19");
                            break;
                        }
                    case '+':
                        {
                            Wrapper.Wrap.Add(input1 += "0x20");
                            break;
                        }
                    case '?':
                        {
                            Wrapper.Wrap.Add(input1 += "0x21");
                            break;
                        }
                    case '<':
                        {
                            Wrapper.Wrap.Add(input1 += "0x22");
                            break;
                        }
                    case '>':
                        {
                            Wrapper.Wrap.Add(input1 += "0x23");
                            break;
                        }
                    case '=':
                        {
                            Wrapper.Wrap.Add(input1 += "0x24");
                            break;
                        }
                    case '-':
                        {
                            Wrapper.Wrap.Add(input1 += "0x25");
                            break;
                        }
                    case '_':
                        {
                            Wrapper.Wrap.Add(input1 += "0x26");
                            break;
                        }
                    case ',':
                        {
                            Wrapper.Wrap.Add(input1 += "0x27");
                            break;
                        }
                    case '\'':
                        {
                            Wrapper.Wrap.Add(input1 += "0x28");
                            break;
                        }
                    case '\"':
                        {
                            Wrapper.Wrap.Add(input1 += "0x29");
                            break;
                        }
                    case '`':
                        {
                            Wrapper.Wrap.Add(input1 += "0x30");
                            break;
                        }
                    case '~':
                        {
                            Wrapper.Wrap.Add(input1 += "0x31");
                            break;
                        }
                    case '1':
                        {
                            Wrapper.Wrap.Add(input1 += "0x32");
                            break;
                        }
                    case '2':
                        {
                            Wrapper.Wrap.Add(input1 += "0x33");
                            break;
                        }
                    case '3':
                        {
                            Wrapper.Wrap.Add(input1 += "0x34");
                            break;
                        }
                    case '4':
                        {
                            Wrapper.Wrap.Add(input1 += "0x35");
                            break;
                        }
                    case '5':
                        {
                            Wrapper.Wrap.Add(input1 += "0x36");
                            break;
                        }
                    case '6':
                        {
                            Wrapper.Wrap.Add(input1 += "0x37");
                            break;
                        }
                    case '7':
                        {
                            Wrapper.Wrap.Add(input1 += "0x38");
                            break;
                        }
                    case '8':
                        {
                            Wrapper.Wrap.Add(input1 += "0x39");
                            break;
                        }
                    case '9':
                        {
                            Wrapper.Wrap.Add(input1 += "0x40");
                            break;
                        }
                    case '0':
                        {
                            Wrapper.Wrap.Add(input1 += "0x41");
                            break;
                        }
                    case 'A':
                        {
                            Wrapper.Wrap.Add(input1 += "0x42");
                            break;
                        }
                    case 'B':
                        {
                            Wrapper.Wrap.Add(input1 += "0x43");
                            break;
                        }
                    case 'C':
                        {
                            Wrapper.Wrap.Add(input1 += "0x44");
                            break;
                        }
                    case 'D':
                        {
                            Wrapper.Wrap.Add(input1 += "0x55");
                            break;
                        }
                    case 'E':
                        {
                            Wrapper.Wrap.Add(input1 += "0x56");
                            break;
                        }
                    case 'F':
                        {
                            Wrapper.Wrap.Add(input1 += "0x57");
                            break;
                        }
                    case 'G':
                        {
                            Wrapper.Wrap.Add(input1 += "0x58");
                            break;
                        }
                    case 'H':
                        {
                            Wrapper.Wrap.Add(input1 += "0x59");
                            break;
                        }
                    case 'I':
                        {
                            Wrapper.Wrap.Add(input1 += "0x60");
                            break;
                        }
                    case 'J':
                        {
                            Wrapper.Wrap.Add(input1 += "0x61");
                            break;
                        }
                    case 'K':
                        {
                            Wrapper.Wrap.Add(input1 += "0x62");
                            break;
                        }
                    case 'L':
                        {
                            Wrapper.Wrap.Add(input1 += "0x63");
                            break;
                        }
                    case 'M':
                        {
                            Wrapper.Wrap.Add(input1 += "0x64");
                            break;
                        }
                    case 'N':
                        {
                            Wrapper.Wrap.Add(input1 += "0x65");
                            break;
                        }
                    case 'O':
                        {
                            Wrapper.Wrap.Add(input1 += "0x66");
                            break;
                        }
                    case 'P':
                        {
                            Wrapper.Wrap.Add(input1 += "0x67");
                            break;
                        }
                    case 'Q':
                        {
                            Wrapper.Wrap.Add(input1 += "0x68");
                            break;
                        }
                    case 'R':
                        {
                            Wrapper.Wrap.Add(input1 += "0x69");
                            break;
                        }
                    case 'S':
                        {
                            Wrapper.Wrap.Add(input1 += "0x70");
                            break;
                        }
                    case 'T':
                        {
                            Wrapper.Wrap.Add(input1 += "0x71");
                            break;
                        }
                    case 'U':
                        {
                            Wrapper.Wrap.Add(input1 += "0x72");
                            break;
                        }
                    case 'V':
                        {
                            Wrapper.Wrap.Add(input1 += "0x73");
                            break;
                        }
                    case 'W':
                        {
                            Wrapper.Wrap.Add(input1 += "0x74");
                            break;
                        }
                    case 'X':
                        {
                            Wrapper.Wrap.Add(input1 += "0x75");
                            break;
                        }
                    case 'Y':
                        {
                            Wrapper.Wrap.Add(input1 += "0x76");
                            break;
                        }
                    case 'Z':
                        {
                            Wrapper.Wrap.Add(input1 += "0x77");
                            break;
                        }
                    case 'a':
                        {
                            Wrapper.Wrap.Add(input1 += "0x78");
                            break;
                        }
                    case 'b':
                        {
                            Wrapper.Wrap.Add(input1 += "0x79");
                            break;
                        }
                    case 'c':
                        {
                            Wrapper.Wrap.Add(input1 += "0x80");
                            break;
                        }
                    case 'd':
                        {
                            Wrapper.Wrap.Add(input1 += "0x81");
                            break;
                        }
                    case 'e':
                        {
                            Wrapper.Wrap.Add(input1 += "0x82");
                            break;
                        }
                    case 'f':
                        {
                            Wrapper.Wrap.Add(input1 += "0x83");
                            break;
                        }
                    case 'g':
                        {
                            Wrapper.Wrap.Add(input1 += "0x84");
                            break;
                        }
                    case 'h':
                        {
                            Wrapper.Wrap.Add(input1 += "0x85");
                            break;
                        }
                    case 'i':
                        {
                            Wrapper.Wrap.Add(input1 += "0x86");
                            break;
                        }
                    case 'j':
                        {
                            Wrapper.Wrap.Add(input1 += "0x87");
                            break;
                        }
                    case 'k':
                        {
                            Wrapper.Wrap.Add(input1 += "0x88");
                            break;
                        }
                    case 'l':
                        {
                            Wrapper.Wrap.Add(input1 += "0x89");
                            break;
                        }
                    case 'm':
                        {
                            Wrapper.Wrap.Add(input1 += "0x90");
                            break;
                        }
                    case 'n':
                        {
                            Wrapper.Wrap.Add(input1 += "0x91");
                            break;
                        }
                    case 'o':
                        {
                            Wrapper.Wrap.Add(input1 += "0x92");
                            break;
                        }
                    case 'p':
                        {
                            Wrapper.Wrap.Add(input1 += "0x93");
                            break;
                        }
                    case 'q':
                        {
                            Wrapper.Wrap.Add(input1 += "0x94");
                            break;
                        }
                    case 'r':
                        {
                            Wrapper.Wrap.Add(input1 += "0x95");
                            break;
                        }
                    case 's':
                        {
                            Wrapper.Wrap.Add(input1 += "0x95");
                            break;
                        }
                    case 't':
                        {
                            Wrapper.Wrap.Add(input1 += "0x96");
                            break;
                        }
                    case 'u':
                        {
                            Wrapper.Wrap.Add(input1 += "0x97");
                            break;
                        }
                    case 'v':
                        {
                            Wrapper.Wrap.Add(input1 += "0x98");
                            break;
                        }
                    case 'w':
                        {
                            Wrapper.Wrap.Add(input1 += "0x99");
                            break;
                        }
                    case 'x':
                        {
                            Wrapper.Wrap.Add(input1 += "0x100");
                            break;
                        }
                    case 'y':
                        {
                            Wrapper.Wrap.Add(input1 += "0x101");
                            break;
                        }
                    case 'z':
                        {
                            Wrapper.Wrap.Add(input1 += "0x102");
                            break;
                        }
                    case ' ':
                        {
                            Wrapper.Wrap.Add(input1 += "0x103");
                            break;
                        }
                }
            }
            return input1;
        }
    }
}
