using System.ComponentModel.DataAnnotations;

namespace mtgv2_api.Models
{
    public class Card
    {
        // Primary identifiers
        public required string oracle_id { get; set; }
        public required string scryfall_id { get; set; }
        
        // Basic card information
        [Required]
        [MaxLength(200)]
        public string card_name { get; set; } = string.Empty;
        
        [MaxLength(500)]
        public string? type_line { get; set; }
        
        [MaxLength(50)]
        public double? cmc { get; set; }
        
        // Power/Toughness/Loyalty
        public string? power { get; set; }
        public string? toughness { get; set; }
        public string? loyalty { get; set; }
        public string? defense { get; set; }
        
        // Game mechanics
        [MaxLength(1000)]
        public string? keywords { get; set; }
        
        [MaxLength(50)]
        public string? layout { get; set; }
        
        public string? hand_modifier { get; set; }
        public string? life_modifier { get; set; }
        
        // Colors and mana
        [MaxLength(100)]
        public string? colors { get; set; }
        
        [MaxLength(100)]
        public string? color_identity { get; set; }
        
        [MaxLength(100)]
        public string? color_indicator { get; set; }
        
        public string? color_complexity { get; set; }
        
        // Set information
        [MaxLength(10)]
        public string? set { get; set; }
        
        [MaxLength(100)]
        public string? set_name { get; set; }
        
        [MaxLength(50)]
        public string? set_type { get; set; }
        
        [MaxLength(20)]
        public string? rarity { get; set; }
        
        public string? released_date { get; set; }
        
        [MaxLength(10)]
        public string? latest_printing_set { get; set; }
    

        public string? cmc_tier { get; set; }
        
        // Pricing information
        public string? price_usd { get; set; }
        public string? price_usd_foil { get; set; }
        public string? price_usd_etched { get; set; }
        public string? price_eur { get; set; }
        public string? price_eur_foil { get; set; }
        public string? price_tix { get; set; }
        public int? price_tcgplayer { get; set; }
        public int? price_cardkingdom { get; set; }
        public int? price_cardmarket { get; set; }
        public int? best_usd_price { get; set; }
        public int? foil_premium_percent { get; set; }
        public double? price_percentile_in_set_rarity { get; set; }
        public double? price_volatility { get; set; }
        
        // Price availability flags
        public bool? has_usd_price { get; set; }
        public bool? has_usd_foil_price { get; set; }
        public bool? has_eur_price { get; set; }
        public bool? has_tix_price { get; set; }
        public bool? has_tcgplayer_price { get; set; }
        public bool? has_cardkingdom_price { get; set; }
        public bool? has_cardmarket_price { get; set; }
        
        // Card characteristics
        public bool? has_content_warning { get; set; }
        public bool? is_digital { get; set; }
        public bool? is_promo { get; set; }
        public bool? is_reprint { get; set; }
        public bool? is_variation { get; set; }
        public bool? is_spoiler { get; set; }
        public bool? is_gamechanger { get; set; }
        public bool? is_tutor { get; set; }
        public bool? is_extraturn { get; set; }
        public bool? is_masslanddenial { get; set; }
        public bool? is_reserved { get; set; }
        
        // Variants and counts
        public int? variant_count { get; set; }
        public int? price_source_count { get; set; }
        
        // Format legality
        public long? legal_formats_count { get; set; }
        public long? banned_formats_count { get; set; }
        
        public bool? is_commander_legal { get; set; }
        public bool? is_modern_legal { get; set; }
        public bool? is_legacy_legal { get; set; }
        public bool? is_vintage_legal { get; set; }
        public bool? is_pauper_legal { get; set; }
        public bool? is_pioneer_legal { get; set; }
        public bool? is_standard_legal { get; set; }
        public string? legal_brawl { get; set; }
        public string? legal_predh { get; set; }
        public string? legal_legacy { get; set; }
        public string? legal_modern { get; set; }
        public string? legal_pauper { get; set; }
        public string? legal_pioneer { get; set; }
        public string? legal_vintage { get; set; }
        public string? legal_standard { get; set; }
        public string? legal_commander { get; set; }
        public string? legal_premodern { get; set; }
        public string? legal_oathbreaker { get; set; }
        public string? legal_paupercommander { get; set; }
        public string? legal_paupercommandermain { get; set; }
        
        // Additional metadata
        [MaxLength(50)]
        public long? cs_card_id { get; set; }
        
        [MaxLength(50)]
        public string? price_tier { get; set; }
        
        [MaxLength(50)]
        public string? release_era { get; set; }
        
        [MaxLength(100)]
        public string? games { get; set; }
        
        [MaxLength(1000)]
        public string? features { get; set; }
        
        public string? data_coverage { get; set; }
        
        [MaxLength(100)]
        public string? primary_type { get; set; }
        
        // Image URLs
        [MaxLength(500)]
        public string? image_small { get; set; }
        
        [MaxLength(500)]
        public string? image_normal { get; set; }
        
        [MaxLength(500)]
        public string? image_large { get; set; }
        
        [MaxLength(500)]
        public string? image_png { get; set; }
        
        [MaxLength(500)]
        public string? image_art_crop { get; set; }
        
        [MaxLength(500)]
        public string? image_border_crop { get; set; }
        
        [MaxLength(500)]
        public string? image_uri_back_png { get; set; }
        
        [MaxLength(500)]
        public string? image_uri_back_large { get; set; }
        
        [MaxLength(500)]
        public string? image_uri_back_normal { get; set; }
        
        [MaxLength(500)]
        public string? image_uri_back_small { get; set; }
        
        [MaxLength(500)]
        public string? image_uri_back_art_crop { get; set; }
        
    }
}
