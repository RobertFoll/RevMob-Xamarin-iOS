public enum RevMobButtonStatus
{
	Undefined = -1,
	New = 0,
	Loading,
	Loaded,
	LoadError
}

public enum RevMobAdsTestingMode : uint
{
	Off = 0,
	WithAds,
	WithoutAds
}

public enum RevMobUserGender : uint
{
	Undefined = 0,
	Male,
	Female
}

public enum RevMobParallaxMode : uint
{
	Off = 0,
	Default,
	WithBackground
}
