/* SafeClientUser.cs -- 
   Copyright (C) 2008  Pacific Biosciences.  */


using System;
using System.Text;

namespace P4API
{
	/// <summary>
	/// This class overrides the default implementation of ClientUser
	/// to divert the unsafe methods to safe ones; the safe methods can
	/// then be overridden in your implementation.
	/// </summary>
	public class SafeClientUser : ClientUser
	{
#region Unsafe methods
		public unsafe override void OutputText(sbyte *data, int length)
		{
			OutputText(new String(data, 0, length, new UTF8Encoding()));
		}

		public unsafe override void OutputBinary(sbyte *data, int length)
		{
			/* FIXME - is there a memcpy-ish way to do this? */
			byte[] array = new byte[length];
			for (int i = 0; i < length; i++)
				array[i] = unchecked((byte) data[i]);
			OutputBinary(array);
		}
#endregion

#region Safe methods
		public virtual void OutputText(string text)
		{
			System.Console.WriteLine(text);
		}

		public virtual void OutputBinary(byte[] data)
		{
			/* Does nothing. */
		}
#endregion
	}
}