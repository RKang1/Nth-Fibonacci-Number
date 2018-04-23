public int retNFib(int input)
	{
		int seq;
		
		if(input < 2)
		{
			return input;
		}
		
		int num1 = 1;
		int num2 = 1;
		
		for(int i=2; i<input; i++)
		{
			num2 += num1;
			num1 = num2 - num1;
		}
		
		seq = num2;
		
		return seq;
}
