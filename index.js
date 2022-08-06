//-----------------------------------------------------------------------------
// NodeJS App for GCP Cloud Functions deployed via GCP Cloud Build Triggers
//-----------------------------------------------------------------------------

exports.helloWorld = (req, res) => {
  const message="<font color='blue'>Hello from Dmitriy!</font><br><b>App Version 1.3</b>";
  res.status(200).send(message);
};
