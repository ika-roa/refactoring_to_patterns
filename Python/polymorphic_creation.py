import random


class Field:
    def __init__(self, location):
        self._location = location
        self._farmers = [Farmer("Anna"), Farmer("Bea"), Farmer("Chloe")]

    def grow_food(self, product):
        farmer = random.choice(self._farmers)
        farmer.create_food_source_in(self._location)
        farmer.harvest(product)
        farmer.send(product)


class Garden:
    def __init__(self, location):
        self._location = location
        self._gardeners = [Gardener("Dan"), Gardener("Eddie"), Gardener("Finn")]

    def grow_food(self, product):
        gardener = random.choice(self._gardeners)
        gardener.create_food_source_in(self._location)
        gardener.harvest(product)
        gardener.send(product)


class Farmer:
    def __init__(self, name):
        self._name = name

    def create_food_source_in(self, location):
        print(f"{self._name} plants a field in {location}.")

    def harvest(self, product):
        print(f"{self._name} harvests {product} from field.")

    def send(self, product):
        print(f"{self._name} sends {product} to the factory.")


class Gardener:
    def __init__(self, name):
        self._name = name

    def create_food_source_in(self, location):
        print(f"{self._name} plants a garden in {location}.")

    def harvest(self, product):
        print(f"{self._name} harvests {product} from garden.")

    def send(self, product):
        print(f"{self._name} sends {product} to the market.")
