﻿using System;

namespace HelloWorld
{
    public partial class Program
    {
        public class GenericList<T> {
            public void Add(T value) {
                throw new NotImplementedException();
            }

            public T this[int index] {
                get { throw new NotImplementedException(); }
            }
        }
    }
}