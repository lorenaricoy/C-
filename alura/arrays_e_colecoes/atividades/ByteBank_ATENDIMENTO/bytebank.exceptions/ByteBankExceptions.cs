﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ATENDIMENTO.bytebank.exceptions
{
	 [System.Serializable]
	public class ByteBankException : Exception
	{
		public ByteBankException() { }
		public ByteBankException(string message) : base("Aconteceu uma excecao->" + 
			message) { }
		public ByteBankException(string message, Exception inner) : base(message, inner) { }
		protected ByteBankException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
