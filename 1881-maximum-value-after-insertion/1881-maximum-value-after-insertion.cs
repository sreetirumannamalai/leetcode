public class Solution
{
	public string MaxValue(string n, int x)
	{
		bool isInserted = false;
		StringBuilder res = new StringBuilder();

		if (n[0] == '-')
		{
			res.Append('-');

			for (int i = 1; i < n.Length; i++)
			{
				if (!isInserted && (n[i] - '0') > x)
				{
					res.Append(x);
					isInserted = true;
				}

				res.Append(n[i]);
			}
		}
		else
		{
			for (int i = 0; i < n.Length; i++)
			{
				if (!isInserted && (n[i] - '0') < x)
				{
					res.Append(x);
					isInserted = true;
				}

				res.Append(n[i]);
			}
		}

		if (res.Length == n.Length)
			res.Append(x);

		return res.ToString();
	}
}