from Python.polymorphic_creation import Field, Garden


def test_that_a_field_produces_food():
    location = "Berlin"
    product = "Potato"

    field = Field(location)
    field.grow_food(product)


def test_that_a_garden_produces_food():
    location = "Hamburg"
    product = "Apple"

    garden = Garden(location)
    garden.grow_food(product)
