(function () {
    "use strict";

    function Controller($scope, listViewHelper,editorService) {
   
        var vm = this;

        vm.items = [
            {
                "icon": "icon-document",
                "name": "My node 1",
                "published": true,
                "description": "A short description of my node",
                "author": "Author 1"
            },
            {
                "icon": "icon-document",
                "name": "My node 2",
                "published": true,
                "description": "A short description of my node",
                "author": "Author 2"
            }
        ];

        vm.options = {
            includeProperties: [
                { alias: "description", header: "Description" },
                { alias: "author", header: "Author" }
                
            ]
        };

        vm.selection = [];

        vm.selectItem = selectItem;
        vm.clickItem = clickItem;
        vm.selectAll = selectAll;
        vm.isSelectedAll = isSelectedAll;
        vm.isSortDirection = isSortDirection;
        vm.sort = sort;

        function selectAll() {
            listViewHelper.selectAllItemsToggle(vm.items, vm.selection);
        }

        function isSelectedAll() {
            return listViewHelper.isSelectedAll(vm.items, vm.selection);
        }

         
        function clickItem(item) {
            listViewHelper.editItem(item);
        }

        function selectItem(item, $index, $event) {
            listViewHelper.selectHandler(item, $index, vm.items, vm.selection, $event);
        }

        function isSortDirection(col, direction) {
            return listViewHelper.setSortingDirection(col, direction, vm.options);
        }

        function sort(field, allow) {
            if (allow) {
                listViewHelper.setSorting(field, allow, vm.options);
                //  $scope.getContent($scope.contentId);
            }
        }

    }

    angular.module("umbraco").controller("TableController", Controller);

})();