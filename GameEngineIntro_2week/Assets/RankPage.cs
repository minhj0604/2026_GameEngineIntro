using System.Linq;
using UnityEngine;
using TMPro;

public class RankPage : MonoBehaviour
{
    [SerializeField] Transform contentRoot;
    [SerializeField] GameObject rowPrefab;

    StageResultList allData;

 
    public void RefreshRankList(int stageNum)
    {
      
        allData = StageResultSaver.LoadRank();

      
        foreach (Transform child in contentRoot)
        {
            Destroy(child.gameObject);
        }

        if (allData == null || allData.results == null) return;

      
        var sortedData = allData.results.Where(r => r.stage == stageNum).OrderByDescending(x => x.score).ToList();

        for (int i = 0; i < sortedData.Count; i++)
        {
            GameObject row = Instantiate(rowPrefab, contentRoot);
            TMP_Text rankText = row.GetComponentInChildren<TMP_Text>();
            rankText.text = $"{i + 1}. {sortedData[i].playerName} - {sortedData[i].score}";
        }
    }
}