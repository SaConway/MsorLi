package md59ce7a3286e2a58b5ab0d064143ff1326;


public class IShareService
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MsorLi.Droid.IShareService, MsorLi.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", IShareService.class, __md_methods);
	}


	public IShareService ()
	{
		super ();
		if (getClass () == IShareService.class)
			mono.android.TypeManager.Activate ("MsorLi.Droid.IShareService, MsorLi.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
