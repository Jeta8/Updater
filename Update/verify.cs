private void f_main_Load(object sender, EventArgs e)
    {
        VerifyUpdate();
    }

private void VerifyUpdate()
        var vlocal = new Version(Assembly.GetExecutingAssembly().GetName().Version.ToString());
    
        var vremote = new Version(DownloadVersion().FirstOrDefault());


        var result = vlocal.CompareTo(vremot);
        if (result < 0)
        {
            UpdateQuestion();
        }
        else
        {
            AlreadyUpdateQuestion();
        }