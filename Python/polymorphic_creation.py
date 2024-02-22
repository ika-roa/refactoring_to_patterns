import random


class Field:
    def __init__(self, location):
        self._location = location
        self._farmers = [Farmer("Anna"), Farmer("Bea"), Farmer("Chloe")]

    def grow_food(self, product):
        farmer = self.create_producer()
        farmer.create_food_source_in(self._location)
        farmer.harvest(product)
        farmer.send(product)

    def create_producer(self):
        return random.choice(self._farmers)


class Farmer:
    def __init__(self, name):
        self._name = name

    def create_food_source_in(self, location):
        print(f"{self._name} plants a field in {location}.")

    def harvest(self, product):
        print(f"{self._name} harvests {product} from field.")

    def send(self, product):
        print(f"{self._name} sends {product} to the factory.")


class Garden:
    def __init__(self, location):
        self._location = location
        self._gardeners = [Gardener("Dan"), Gardener("Eddie"), Gardener("Finn")]

    def grow_food(self, product):
        gardener = self.create_producer()
        gardener.create_food_source_in(self._location)
        gardener.harvest(product)
        gardener.send(product)

    def create_producer(self):
        return random.choice(self._gardeners)


class Gardener:
    def __init__(self, name):
        self._name = name

    def create_food_source_in(self, location):
        print(f"{self._name} plants a garden in {location}.")

    def harvest(self, product):
        print(f"{self._name} harvests {product} from garden.")

    def send(self, product):
        print(f"{self._name} sends {product} to the market.")
