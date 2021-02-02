using System;

class MainClass {
	private static void loopNum (int randomNumber) {
		if (randomNumber > 1) {
			int i;
			for (i = 0; i < 4; i++) {
				if ((randomNumber - 1) == i) {
					string spaces = null;
					int a;
					for (a = 0; a < i; a++) {
						if (spaces != null) {
							spaces = spaces + " ";
						} else {
							spaces = " ";
						}
					}
					Console.WriteLine(spaces + "▓");
				}
			}
		} else {
			Console.WriteLine("▓");
		}
	}

	private static void Start () {
		int randomNumber;
		Random RNG = new Random();
		randomNumber = RNG.Next(1,5);
		//Console.WriteLine(randomNumber);
		loopNum(randomNumber);
		Cont(randomNumber);
	}

  public static void Main (string[] args) {
    Start();
  }

	public static void Cont (int lastNum) {
		int randomNumber;
		Random RNG = new Random();
		randomNumber = RNG.Next(1,5);
		if (randomNumber == lastNum) {
			Cont(lastNum);
		} else {
			loopNum(randomNumber);
			Cont(randomNumber);
		}
	}
}