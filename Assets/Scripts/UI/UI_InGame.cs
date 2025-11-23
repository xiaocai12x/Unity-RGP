using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame : MonoBehaviour
{
    private Player player;
    private UI_SkillSlot[] skillSlots;

    [SerializeField] private RectTransform healthRect;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private TextMeshProUGUI healthText;

    private void Start()
    {
        player = FindFirstObjectByType<Player>();
        player.health.OnHealthUpdate += UpdateHealthBar;

    }

    public UI_SkillSlot GetSkillSlot(SkillType skillType)
    {
        if(skillSlots == null)
            skillSlots = GetComponentsInChildren<UI_SkillSlot>(true);


        foreach (var slot in skillSlots)
        {
            if (slot.skillType == skillType)
            {
                slot.gameObject.SetActive(true);
                return slot;
            }
        }

        return null;
    }


    private void UpdateHealthBar()
    {
        float currentHealth = Mathf.RoundToInt(player.health.GetCurrentHealth());
        float maxHealth = player.stats.GetMaxHealth();
        //float sizeDiffrence = Mathf.Abs(currentHealth - healthRect.sizeDelta.x);

        //if(sizeDiffrence >  .1f)
        //    healthRect.sizeDelta = new Vector2(currentHealth, healthRect.sizeDelta.x);

        healthText.text = currentHealth + "/" + maxHealth;
        healthSlider.value = player.health.GetHealthPercent();
    }
}
