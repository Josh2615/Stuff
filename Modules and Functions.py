import math  # math is a module containing (surprise) useful mathematical functions


def if_answer_is_an_int_or_float_kill_roach(ans):
    if type(ans) == int or type(ans) == float:  # type() returns the type of parameter entered
        print("Roach obliterated!")
    else:
        print(
            "Since you chose to be a rebel and enter a string or any other LAME value type, the roaches have "
            "single-handedly taken over all of the known universe. Thanks a lot, jerk!")


if_answer_is_an_int_or_float_kill_roach("I'm a rebel!!!")


def square(num):
    return num * num


print(square(5))  # Should print 25
print(math.sqrt(25))  # Should print 5; sqrt is one of math's many functions
print(dir(math))  # These are all the functions in the math module.
print(max(len("Josh"), len("Summer"), len("Winter is coming!")))  # Gives the maximum value of a set of numbers
print(min(2.5, 77, -99.3))  # Gives the minimum value of a set of numbers
print(abs(-15))  # Gives the absolute value of a number; can only accept one argument.
