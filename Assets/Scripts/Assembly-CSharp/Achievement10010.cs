using System;

[Serializable]
public class Achievement10010 : Achievement<AchievementData10010>
{
	protected override void DoProcess()
	{
		base.Progress = (float)AchievementTool.GetUsedItemCount(data.usedItemId) * 1f / (float)data.count;
		if (Progress > 1f)
		{
			base.Progress = 1f;
		}
	}
}
