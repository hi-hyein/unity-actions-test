using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SquareTest
    {
        [UnityTest]
        public IEnumerator SquareWithEnumeratorPasses()
        {
            var Obj = new GameObject();
            Square mySquare = Obj.AddComponent<Square>();

            yield return null;

            Assert.AreEqual(5, mySquare.SquareTest(2, 2));
        }
    }
}
