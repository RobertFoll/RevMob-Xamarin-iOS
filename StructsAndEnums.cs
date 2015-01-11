namespace RevMob.iOS
{
	public enum RevMobButtonStatus {
		RevMobButtonStatusUndefined = -1,
		RevMobButtonStatusNew = 0,
		RevMobButtonStatusLoading,
		RevMobButtonStatusLoaded,
		RevMobButtonStatusLoadError
	}

	public enum RevMobAdsTestingMode : uint {
		RevMobAdsTestingModeOff = 0,
		RevMobAdsTestingModeWithAds,
		RevMobAdsTestingModeWithoutAds
	}

	public enum RevMobUserGender : uint {
		RevMobUserGenderUndefined = 0,
		RevMobUserGenderMale,
		RevMobUserGenderFemale
	}

	public enum RevMobParallaxMode : uint {
		RevMobParallaxModeOff = 0,
		RevMobParallaxModeDefault,
		RevMobParallaxModeWithBackground
	}
}