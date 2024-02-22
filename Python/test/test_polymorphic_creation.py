from Python.polymorphic_creation import Field


def test_that_a_field_produces_food():
    location = "Berlin"
    product = "Potato"

    field = Field(location)
    field.grow_food(product)
