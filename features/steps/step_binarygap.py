from behave import given, then
from hamcrest import *
from binarygap import BinaryGap


@given('Create an instance of BinaryGap n: "{n}"')
def step(context, n):
    context.gap = BinaryGap(n)


@then('"{n}" to binary : "{result}"')
def step_impl(context,n,result):
    assert_that(context.gap.convert_to_binary(n), result)


@then('Max Gap of this number :: "{result}"')
def step_impl(context,result):
    assert_that(context.gap.get_binary_gap(), equal_to(int(result)))


def toIntArray(strArray):
    array = []
    for i in strArray:
        array.append(int(i))
    return array