
using UnityEngine;

namespace TestSimplePackage.Scripts
{
    public sealed class TestScript
    {
        public string Message => "Hello World! from Test simple package";
        public string Message2 => "Hello World! 2 from Test simple package";
        public string Message3 => "Hello World! 2 from Test simple package";
        public string Message4 => "Hello World! 2 from Test simple package";
        public string Message5 => "Hello World! 2 from Test simple package";
        
        public void PrintMessage() => Debug.Log(Message);
    }
}