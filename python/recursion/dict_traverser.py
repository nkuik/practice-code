def traverse(d):
  for k, v in d.items():
    if isinstance(v, dict):
      traverse(v)
    else:
      print("{0} : {1}".format(k, v))
