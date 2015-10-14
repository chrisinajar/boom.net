using System;

namespace Boom
{
	public class BoomException : Exception
	{
		// not static because we want (e.isBoom) to work
		// also basically entirely pointless because statically typed, but whatever
		public readonly bool isBoom = true;
		public bool isServer {
			get {
				return this.output.statusCode >= 500;
			}
			set { }
		}
		public BoomOutput output;


		public BoomException (string _message, int _statusCode = 500)
			: base(_message)
		{
			output = new BoomOutput(_message, _statusCode);
		}
	}
}

