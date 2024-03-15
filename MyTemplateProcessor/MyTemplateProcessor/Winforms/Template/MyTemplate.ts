{if len(items) > 2:
    * There are more than two items in map ({len(items)}, actually).
}


{if test:
    * Variable "test" is true!
|else:
    * Variable "test" is false!
}


{if x < 0:
    * X is negative.
|elif x > 0:
    * X is positive.
|else:
    * X is zero.
}


{for index, text in items:
    {index + 1}: {text}


|empty:
    No messages to display.
}