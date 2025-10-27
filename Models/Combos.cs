using System.ComponentModel.DataAnnotations;

namespace mtgv2_api.Models
{
    public class CardCombo
    {
        // Primary identifiers
        public required string variant_id { get; set; }
        public string? card_id { get; set; }
        public required string card_name { get; set; }
        public long? card_position { get; set; }
        public string? card_role { get; set; }
        public string? oracle_id { get; set; }
        
        // Card properties
        [MaxLength(100)]
        public string? type_line { get; set; }
        
        [MaxLength(100)]
        public string? color_identity { get; set; }
        
        public double? cmc { get; set; }
        
        [MaxLength(20)]
        public string? rarity { get; set; }
        
        [MaxLength(100)]
        public string? set_name { get; set; }
        
        public double? card_price { get; set; }
        
        [MaxLength(100)]
        public string? primary_type { get; set; }
        
        public string? cmc_tier { get; set; }
        
        public string? color_complexity { get; set; }
        
        // Combo-specific fields
        [MaxLength(2000)]
        public string? description { get; set; }
        
        [MaxLength(2000)]
        public string? notes { get; set; }
        
        public string? complexity_level { get; set; }
        
        public string? difficulty_level { get; set; }
        
        public string? combo_type { get; set; }
        
        [MaxLength(50)]
        public string? price_tier { get; set; }
        
        public int? legal_formats_count { get; set; }
        
        public int? estimated_card_count { get; set; }
        
        public int? estimated_feature_count { get; set; }
        
        public int? mana_value_needed { get; set; }
        
        public int? popularity { get; set; }
        
        public string? bracket_tag { get; set; }
        
        public decimal? best_price { get; set; }
        
        // Format legality flags
        public string? legal_commander { get; set; }
        public string? legal_modern { get; set; }
        public string? legal_legacy { get; set; }
        public string? legal_vintage { get; set; }
        public string? legal_pauper { get; set; }
        public string? legal_pioneer { get; set; }
        public string? legal_standard { get; set; }
        public string? legal_brawl { get; set; }
        public string? legal_oathbreaker { get; set; }
        public string? legal_paupercommander { get; set; }
        
        // Combo details
        [MaxLength(2000)]
        public string? combo_cards { get; set; }
        
        [MaxLength(2000)]
        public string? combo_uses { get; set; }
        
        [MaxLength(2000)]
        public string? combo_includes { get; set; }
        
        [MaxLength(2000)]
        public string? combo_produces { get; set; }
        
        [MaxLength(2000)]
        public string? combo_requires { get; set; }
        
        public int? search_priority { get; set; }
    }
}
