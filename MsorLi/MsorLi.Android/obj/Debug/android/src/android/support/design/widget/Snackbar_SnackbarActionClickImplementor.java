package android.support.design.widget;


public class Snackbar_SnackbarActionClickImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
<<<<<<< Updated upstream
		mono.android.Runtime.register ("Android.Support.Design.Widget.Snackbar+SnackbarActionClickImplementor, Xamarin.Android.Support.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Snackbar_SnackbarActionClickImplementor.class, __md_methods);
=======
		mono.android.Runtime.register ("Android.Support.Design.Widget.Snackbar+SnackbarActionClickImplementor, Xamarin.Android.Support.Design", Snackbar_SnackbarActionClickImplementor.class, __md_methods);
>>>>>>> Stashed changes
	}


	public Snackbar_SnackbarActionClickImplementor ()
	{
		super ();
		if (getClass () == Snackbar_SnackbarActionClickImplementor.class)
<<<<<<< Updated upstream
			mono.android.TypeManager.Activate ("Android.Support.Design.Widget.Snackbar+SnackbarActionClickImplementor, Xamarin.Android.Support.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
=======
			mono.android.TypeManager.Activate ("Android.Support.Design.Widget.Snackbar+SnackbarActionClickImplementor, Xamarin.Android.Support.Design", "", this, new java.lang.Object[] {  });
>>>>>>> Stashed changes
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
