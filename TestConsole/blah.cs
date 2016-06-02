using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
	public class blah
	{
		public blah()
		{

		}

		public IEnumerable<int> getBlah()
		{
			int i = 0;
			while (true)
			{
				yield return i+=2;
			}
		}
	}
}
