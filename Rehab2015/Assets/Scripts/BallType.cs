using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace Assets.Scripts
//{

public class BallType
{
	public string ModelName;
	public string LaunchSound;
	public string CatchSound;

	public BallType(string modelName, string launchSound, string catchSound)
	{
		this.ModelName = modelName;
		this.LaunchSound = launchSound;
		this.CatchSound = catchSound;
	}
}
//}
