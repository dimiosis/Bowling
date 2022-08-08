//-----------------------------------------------------------------------------
// NodeJS App for GCP Cloud Functions deployed via GCP Cloud Build Triggers
//-----------------------------------------------------------------------------

exports.helloWorld = (req, res) => {
  const message="<font color='blue'>Hello from Dmitriy! FINISH</font><br><b>App Version 3.0.0</b>";
  res.status(200).send(message);
};
