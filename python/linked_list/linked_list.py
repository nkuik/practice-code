class List():
  def __init__(self, value, child):
    self.value = value # int
    self.child = child # List (or None)

def length(l): # type(l) in [List, None]
  if (l is None):
    return 0
  else:
    return 1 + length(l.child)