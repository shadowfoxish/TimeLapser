using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapser
{
	public class ListItem<TKey>
	{
		public TKey Key { get; set; }

		public string Value { get; set; }

		public override string ToString()
		{
			return Value;
		}

		public override bool Equals(object obj)
		{
			var tst = obj as ListItem<TKey>;
			if (tst != null)
			{
				return this.Key.Equals(((ListItem<TKey>)tst).Key);
			}
			else
			{
				return false;
			}
		}

		public override int GetHashCode()
		{
			return this.Key.GetHashCode();
		}
	}
}
