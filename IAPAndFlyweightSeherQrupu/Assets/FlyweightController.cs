using System.Collections.Generic;
using UnityEngine;

public class FlyweightController : MonoBehaviour
{
	[SerializeField] private List<Alien> alienList=new List<Alien>();

	static List<Vector3> eyePositions = new List<Vector3>();

	static List<Vector3> handPositions = new List<Vector3>();

	static List<Vector3> tentaclesPositions = new List<Vector3>();
	void Start()
	{
		eyePositions = ReturnBodyPos();

		handPositions = ReturnBodyPos();

		tentaclesPositions = ReturnBodyPos();



		for (int i = 0; i < 10000; i++)
		{
			Alien newAlien = new Alien(eyePositions, handPositions, tentaclesPositions);


			alienList.Add(newAlien);
		}




		//for (int i = 0; i < 10000; i++)
		//{
		//	Alien newAlien = new Alien(ReturnBodyPos(),ReturnBodyPos(),ReturnBodyPos());


		//	alienList.Add(newAlien);
		//}
	}

	public List<Vector3> ReturnBodyPos()
	{
		List<Vector3> bodyPos = new List<Vector3>();

		for(int i = 0; i < 10000; i++)
		{
			Vector3 pos = new Vector3(0, 0, 0);

			bodyPos.Add(pos);
		}

		return bodyPos;
	}


}

public class Alien
{
	public List<Vector3> eyePos;

	public List<Vector3> handPos;

	public List<Vector3> tenctaclePos;

	public Alien(List<Vector3> eyePos, List<Vector3> handPos, List<Vector3> tenctaclePos)
	{
		this.eyePos = eyePos;
		this.handPos = handPos;
		this.tenctaclePos = tenctaclePos;
	}
}