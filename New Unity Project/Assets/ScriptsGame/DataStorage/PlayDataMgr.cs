using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDataMgr
{
	private static PlayDataMgr instance;
	public static PlayDataMgr Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new PlayDataMgr();
			}
			return instance;
		}
	}

	public void Init()
	{
		JsonDataHandler<RoleData> roleDataHandler = new JsonDataHandler<RoleData>();
		// roleDataHandler.m_Data.hp = 80;
		// roleDataHandler.Write();
		roleDataHandler.Read();
		Debug.Log(roleDataHandler.m_Data.hp);
	}
}
