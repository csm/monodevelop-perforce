/* Sample.cs -- 
   Copyright (C) 2008  Pacific Biosciences.  */


using P4API;

class SampleUI : ClientUser
{
	public override void OutputInfo(char level, string data) {
		System.Console.WriteLine("output {0} - {1}", level, data);
	}
}

class Sample
{
	public static void Main(string[] argv)
	{
		ClientApi client = new ClientApi();
		// ClientUser ui = new ClientUser();
		SampleUI ui = new SampleUI();
		Error error = new Error();

		client.Init(error);
		client.Run("info", ui);

		client.SetArgv(new string[] { "-u", "cmarshall" });
		client.Run("clients", ui);
		client.Final(error);
	}
}